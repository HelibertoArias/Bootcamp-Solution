// <copyright file="CompanyRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System.Diagnostics;

namespace Decorator;
public class CompanyRepositoryDecorated : ICompanyRepository
{
    private readonly ICompanyRepository _companyRepository;
    private readonly ILogger _logger;

    public CompanyRepositoryDecorated(ICompanyRepository companyRepository, ILogger logger )
    {
         this._companyRepository = companyRepository ;
        this._logger = logger;
    }

    public Task<int> AddCompany(Company company)
    {
        Stopwatch sw = Stopwatch.StartNew();

        var result = _companyRepository.AddCompany(company);

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running AddCompany for {company.Name} - Elapsed ms: {elapsed}");

        return result;
    }

    public void DeleteCompany(Company company)
    {
        Stopwatch sw = Stopwatch.StartNew();

        _companyRepository.DeleteCompany(company);

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running Remove for {company.Name} - Elapsed ms: {elapsed}");
    }

    public Task<List<Company>> GetAll()
    {
        Stopwatch sw = Stopwatch.StartNew();
        var list = _companyRepository.GetAll();

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running GetAll - Elapsed ms: {elapsed}");

        return list;
    }

    public async Task<Company> GetByCompanyName(string companyName)
    {
        Stopwatch sw = Stopwatch.StartNew();

        var item = await _companyRepository.GetByCompanyName(companyName);

        sw.Stop();
        long elapsed = sw.ElapsedMilliseconds;
        _logger.Info($"Running GetByCompanyName for {companyName} - Elapsed ms: {elapsed}");

        return item ;
    }
}


 