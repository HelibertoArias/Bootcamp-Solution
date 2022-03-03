using Newtonsoft.Json;
using System.Net;

namespace TaskWinFormsApp
{
    public partial class Form1 : Form
    {
        private static string API_URL = "https://ps-async.fekberg.com/api/stocks/MSFT";

        // For the exercise
        CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
        }


        //private void button1_Click(object sender, EventArgs e)
        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource = null;
                btnSearch.Text = "Search";

                progressBar1.Visible = false;

                return;
            }


            try
            {
                /*
                *  Instantiate a CancellationTokenSource object, which manages and sends 
                *  cancellation notification to the individual cancellation tokens.
                */
                cancellationTokenSource = new CancellationTokenSource();

                // Register un action to run when the process is stopped.
                cancellationTokenSource.Token.Register(() => { txtContent.Text = "Cancellation requested"; });

                btnSearch.Text = "Cancel";
                txtContent.Text = String.Empty;

                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.Visible = true;


                DataGrdv.DataSource = null;
                /*
                * Pass the token returned by the CancellationTokenSource.Token 
                * property to each task  that listens for cancellation.
                */
                await GetStocksAsync(cancellationTokenSource.Token);

            }
            catch (TaskCanceledException ex) { txtContent.Text = "This task was canceled and throw this error"; }

            catch (Exception ex) {  txtContent.Text = ex.Message; }
            
            finally {
                cancellationTokenSource = null;
                btnSearch.Text = "Search";

                progressBar1.Visible = false;
            }
            
        }

        /// <summary>
        /// Sync operation
        /// </summary>
        private void GetStocks()
        {
            WebClient client = new();

            var content = client.DownloadString($"{API_URL}");

            // Simulate that the web call takes a very long time
            Thread.Sleep(4000);

            var data = JsonConvert.DeserializeObject<IEnumerable<StockPrice>>(content);
            DataGrdv.DataSource = data;
        }

        /*
        * TODO : Implement Cancelation token
        * - Once the user  click in the btnSearch the text label should change from "Start" to "Cancel"
        * - If the user  clik in the cancel button the progress should stop and set a message in the
        *   txtContent something like "The task has stopped". You can use the CancellationToken.Register Method
        *   take a look here https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken.register?view=net-6.0
        *   
        *   cancellationTokenSource.Token.Register(() => { btnSearch.Text = "The task has stopped"; });
        */
        private async Task GetStocksAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(5000);

            using (var client = new HttpClient())
            {
                var responseTask = client.GetAsync($"{API_URL}", cancellationToken);
                var response = await responseTask;

                var content = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<IEnumerable<StockPrice>>(content);

                DataGrdv.DataSource = data;
            }
        }

       


    }
}

