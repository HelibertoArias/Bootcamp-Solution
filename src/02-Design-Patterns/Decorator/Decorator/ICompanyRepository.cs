// <copyright file="ICompanyRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace Decorator;
public interface ICompanyRepository
{
    Task<List<Company>> GetAll();

    Task<int> AddCompany(Company company);

    void DeleteCompany(Company company);

    Task<Company> GetByCompanyName(string companyName);
}
