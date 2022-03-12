// <copyright file="CompanyService.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using Rocco.Logic.Exceptions;

namespace Rocco.Logic;
public class CompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        this._companyRepository = companyRepository;
    }

    public async Task<int> AddCompany(CompanyToAddDto companyDto)
    {
        if (companyDto == null || string.IsNullOrEmpty(companyDto.Name))
        {
            throw new ArgumentNullException(nameof(companyDto));
        }

        var exists = await _companyRepository.GetByCompanyName(companyDto.Name)
                                 .ConfigureAwait(false);

        if (exists != null)
        {
            throw new DuplicatedException(nameof(Company), companyDto.Name);
        }

        var company = new Company
        {
            Name = companyDto.Name,
            Description = companyDto.Description,
        };

        return await _companyRepository.AddCompany(company)
                        .ConfigureAwait(false);
    }

    public async Task<List<CompanyDto>> GetAll()
    {
        var companies = await _companyRepository.GetAll().ConfigureAwait(false);

        var dtos = from company in companies
                   select new CompanyDto
                   {
                       Name = company.Name,
                       Id = company.Id,
                       Description = company.Description
                   };

        return dtos.ToList();
    }



    public async Task DeleteCompany(int companyId)
    {
        var itemToDelete = (await _companyRepository.GetAll().ConfigureAwait(false))
                                .FirstOrDefault(x => x.Id == companyId);

        if (itemToDelete == null)
        {
            throw new NotFoundException(nameof(Company), companyId);
        }

        _companyRepository.DeleteCompany(itemToDelete);
    }

    public Task<Company> GetByCompanyName(string companyName)
    {
        return _companyRepository.GetByCompanyName(companyName);
    }
}
