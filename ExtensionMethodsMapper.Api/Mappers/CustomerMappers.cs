using ExtensionMethodsMapper.Models;
using ExtensionMethodsMapper.Shared;

namespace ExtensionMethodsMapper.Api.Mappers
{
    public static class CustomerMappers
    {
        public static CustomerDetailsDto ToCustomerDetailsDto(this Customer customer)
        {
            return new CustomerDetailsDto
            {
                Id = customer.Id,
                Name = $"{customer.FirstName} {customer.LastName}",
                Phone = customer.Phone,
                Website = customer.Website,
                Addresses = customer.Addresses?.Select(_ => _.ToAddressDto()),

                
            };
        }

        public static CustomerSummaryDto ToCustomerSummaryDto(this Customer customer)
        {
            return new CustomerSummaryDto
            {
                Id = customer.Id,
                Name = $"{customer.FirstName} {customer.LastName}"
            };
        }
    }
}
