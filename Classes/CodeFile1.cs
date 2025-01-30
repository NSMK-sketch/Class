using Classes;

var account = new BankAccount("alex", 1000);
Console.WriteLine($"Акаунт {account.Number} Создан {account.Owner} на нем {account.Balance} баланс.");