namespace CustomerOrderApi.Domain.Commands.Customer
{
    public record CreateCustomerCommand(string FirstName, string LastName, string PostalCode);
}