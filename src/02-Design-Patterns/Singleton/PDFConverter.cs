namespace Singleton
{
    //public class PDFConverter
    //{
    //    private Guid _sessionId;

    //    public PDFConverter()
    //    {
    //        _sessionId = Guid.NewGuid();
    //    }

    //    public void ConvertToPDF(string filePath)
    //    {
    //        // TODO: Convert to PDF
    //    }

    //    public string GetSessionInfo()
    //    {
    //        return "Session Info: " + _sessionId;
    //    }
    //}

    public class PDFConverter
    {
        private Guid _sessionId;

        private static PDFConverter _instance;

        private PDFConverter()
        {
            _sessionId = Guid.NewGuid();
        }

        public static PDFConverter GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PDFConverter();
                }
                return _instance;
            }
        }

        public void ConvertToPDF(string filePath)
        {
            // TODO: Convert to PDF
        }

        public string GetSessionInfo()
        {
            return "Session Info: " + _sessionId;
        }
    }
}
