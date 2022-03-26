// <copyright file="CompanyServiceTest.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

// <copyright file="Class1.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System;
using Moq;
using Rocco.Logic.Exceptions;
using Xunit;

namespace Rocco.Logic.Tests;
public class CompanyServiceTest
{
    [Fact]
    public async void AddCompany_Should_Throw_ArgumentNullException_When_Company_Is_Null()
    {
        var companyRepositoryMock = new Mock<ICompanyRepository>();

        var companyService = new CompanyService(companyRepositoryMock.Object);

        CompanyToAddDto dto = null!;

        await Assert.ThrowsAsync<ArgumentNullException>(async () =>
                   _ = await companyService.AddCompany(dto)
                                           .ConfigureAwait(false)
              ).ConfigureAwait(false);
    }

    [Fact]
    public async void AddCompany_Should_Throw_DuplicatedException_When_CompanyName_Exists_Previously()
    {
        // Arrange
        var companyRepositoryMock = new Mock<ICompanyRepository>();
        var companyService = new CompanyService(companyRepositoryMock.Object);
        CompanyToAddDto dto = new() { Name = "Acme" };

        companyRepositoryMock
            .Setup(x => x.GetByCompanyName(It.IsAny<string>()))
            .ReturnsAsync(new Company());

        // Act

        await Assert.ThrowsAsync<DuplicatedException>(async () =>
            _ = await companyService.AddCompany(dto)
                                     .ConfigureAwait(false)
        ).ConfigureAwait(false);

        // Assert
    }

    [Fact]
    public async void AddCompany_Should_Return_The_Id_When_A_Company_Id_Added()
    {
        // Arrange

        var companyRepositoryMock = new Mock<ICompanyRepository>();
        var companyService = new CompanyService(companyRepositoryMock.Object);

        CompanyToAddDto CompanyToAddDto = new() { Name = "Acme" };

        var idGenerated = 1;
        var idExpected = 1;

        companyRepositoryMock
            .Setup(x => x.AddCompany(It.IsAny<Company>()))

            .ReturnsAsync(idGenerated);

        // Act

        var result = await companyService.AddCompany(CompanyToAddDto)
                                            .ConfigureAwait(false);

        // Assert
        Assert.Equal(idExpected, result);
    }

    /*
    __________  ____  ____ 
       /_  __/ __ \/ __ \/ __ \
        / / / / / / / / / / / /
       / / / /_/ / /_/ / /_/ / 
      /_/  \____/_____/\____/  
   */
    // TODO: Add a test for ValidationException if companyDto.Name is null


}
