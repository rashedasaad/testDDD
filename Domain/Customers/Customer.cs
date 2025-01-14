﻿namespace Domain.Customers;

public abstract class Customer
{  private Customer() { }
    
    public CustomerId Id { get; private set; }
    public string Email { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
}

