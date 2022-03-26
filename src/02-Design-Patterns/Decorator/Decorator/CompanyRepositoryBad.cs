// <copyright file="CompanyRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System.Diagnostics;

namespace Decorator;
public class CompanyRepositoryBad : ICompanyRepository
{
    private readonly List<Company> _companies;
    private readonly ILogger _logger;
    private int _index;

    public CompanyRepositoryBad(ILogger logger)
    {
        _companies = new List<Company>();
        this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task<int> AddCompany(Company company)
    {
        Stopwatch sw = Stopwatch.StartNew();

        company.Id = ++_index;
        _companies.Add(company);

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running AddCompany for {company.Name} - Elapsed ms: {elapsed}");

        return Task.FromResult(_index);
    }

    public void DeleteCompany(Company company)
    {
        Stopwatch sw = Stopwatch.StartNew();

        _companies.Remove(company);

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running Remove for {company.Name} - Elapsed ms: {elapsed}");
    }

    public Task<List<Company>> GetAll()
    {
        Stopwatch sw = Stopwatch.StartNew();

        var list = _companies;
        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running GetAll - Elapsed ms: {elapsed}");

        return Task.FromResult(list);
    }

    public async Task<Company> GetByCompanyName(string companyName)
    {
        Stopwatch sw = Stopwatch.StartNew();
        var item = await _companies.FirstOrDefault(x => x.Name == companyName);

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running GetByCompanyName for {companyName} - Elapsed ms: {elapsed}");

        return Task.FromResult(item);
    }
}
