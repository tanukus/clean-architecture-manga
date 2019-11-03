namespace Application.Boundaries.GetCustomerDetails
{
    using System.Collections.Generic;
    using System;
    using Domain.Customers;
    using Domain.ValueObjects;

    public sealed class GetCustomerDetailsOutput
    {
        public Guid CustomerId { get; }
        public SSN SSN { get; }
        public Name Name { get; }
        public IReadOnlyList<Account> Accounts { get; }

        public GetCustomerDetailsOutput(
            ICustomer customer,
            List<Account> accounts)
        {
            Customer customerEntity = (Customer) customer;
            CustomerId = customerEntity.Id;
            SSN = customerEntity.SSN!.Value;
            Name = customerEntity.Name!.Value;
            Accounts = accounts;
        }
    }
}