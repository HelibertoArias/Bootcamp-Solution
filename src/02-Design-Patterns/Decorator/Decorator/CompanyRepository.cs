// <copyright file="CompanyRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace Decorator;
public class CompanyRepository : ICompanyRepository
{
    private readonly List<Company> _companies;
    private int _index;

    public CompanyRepository()
    {
        _companies = new List<Company>();
    }

    public Task<int> AddCompany(Company company)
    {
        company.Id = ++_index;
        _companies.Add(company);
        return Task.FromResult(_index);
    }

    public void DeleteCompany(Company company)
    {
        _companies.Remove(company);
    }

    public Task<List<Company>> GetAll()
    {
        return Task.FromResult(_companies);
    }

    public Task<Company> GetByCompanyName(string companyName)
    {
        var item = _companies.FirstOrDefault(x => x.Name == companyName);
        return Task.FromResult(item);
    }
}
