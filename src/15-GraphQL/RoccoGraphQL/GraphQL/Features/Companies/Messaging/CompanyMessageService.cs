// <copyright file="CompanyMessageService.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System.Reactive.Linq;
using System.Reactive.Subjects;
using RoccoGraphQL.Domain.Entities;

namespace RoccoGraphQL.GraphQL.Features.Companies.Messaging;

public class CompanyMessageService
{
    private readonly ISubject<CompanyAddedMessage> _messageStream =
        new ReplaySubject<CompanyAddedMessage>(1);

    public CompanyAddedMessage AddCompanyAddedMessage(Company company)
    {
        var message = new CompanyAddedMessage
        {
            Id = company.Id,
            Name = company.Name
        };

        _messageStream.OnNext(message);

        return message;
    }

    public IObservable<CompanyAddedMessage> GetMessages()
    {
        return _messageStream.AsObservable();
    }
}
