using System;

namespace CourseAssignment;

class Program
{
    static void Main(string[] args)
    {
        BudgetManager newBudget = new BudgetManager();

        while (true)
        {
            UserMenu(newBudget);

            static void UserMenu(BudgetManager budgetCategory)
            {
                Console.WriteLine("Welcome to the Budget App.");
                Console.WriteLine("Please select an option below:");
                Console.WriteLine("1) Input Budget");
                Console.WriteLine("2) Input Expenses");
                Console.WriteLine("3) View Current Budget");
                Console.WriteLine("4) View Recent Expenses");
                Console.WriteLine("5) Generate Overview");
                Console.WriteLine("6) Quit");
                Console.WriteLine();

                string response = Console.ReadLine();

                if (response == "1")

                {
                    Console.WriteLine();
                    //budgetCategory.EnterIncome();
                    BudgetItem(budgetCategory);
                    
                }

                else if (response == "2")

                {
                    Console.WriteLine();
                    ExpenseItem(budgetCategory);
                }

                else if (response == "3")
                {
                    Console.WriteLine();
                    budgetCategory.DisplayBudgetItems();
                    budgetCategory.DisplayBudgetTotal();
                }

                else if (response == "4")
                {
                    Console.WriteLine();
                    budgetCategory.DisplayExpenseItems();
                    budgetCategory.DisplayExpenseTotal();
                }

                else if (response == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine(">>>>>>> GENERAL OVERVIEW <<<<<<<");
                    Console.WriteLine();
                    budgetCategory.DisplayBudgetItems();
                    Console.WriteLine();
                    budgetCategory.DisplayBudgetTotal();
                    Console.WriteLine();
                    Console.WriteLine();
                    budgetCategory.DisplayExpenseItems();
                    Console.WriteLine();
                    budgetCategory.DisplayExpenseTotal();
                    Console.WriteLine();
                    Console.WriteLine();
                    budgetCategory.DisplayBudgetExpenseDiff();
                }

            }


            static void BudgetItem(BudgetManager budgetCategory)
            {
                Console.WriteLine("Please select an option below and add a BUDGET category:");
                Console.WriteLine("1) Rent");
                Console.WriteLine("2) Food");
                Console.WriteLine("3) Transportation");
                Console.WriteLine("4) Entertainment");
                Console.WriteLine("5) Shopping");
                Console.WriteLine("6) Add a category");
                Console.WriteLine("7) Edit a category");
                Console.WriteLine("8) Delete a category");
                Console.WriteLine("9) Back to Main Menu");
                Console.WriteLine();

                string response = Console.ReadLine();

                switch (response)
                {
                    case ("1"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddBudgetCategory("Rent", amount);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("2"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount1 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddBudgetCategory("Food", amount1);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("3"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount2 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddBudgetCategory("Transportation", amount2);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("4"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount3 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddBudgetCategory("Entertainment", amount3);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("5"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount4 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddBudgetCategory("Shopping", amount4);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("6"):
                        Console.WriteLine("Please enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter amount: ");
                        decimal amount5 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddBudgetCategory(name, amount5);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("7"):
                        Console.WriteLine("Please enter category name: ");
                        string oldName = Console.ReadLine();
                        Console.WriteLine("Please enter new category name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Please enter new amount: ");
                        decimal newAmount = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.EditBudgetCategory(oldName, newName, newAmount);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("8"):
                        Console.WriteLine("Please enter name: ");
                        string name1 = Console.ReadLine();
                        budgetCategory.DeleteBudgetCategory(name1);
                        budgetCategory.DisplayBudgetItems();
                        budgetCategory.DisplayBudgetTotal();
                        Console.WriteLine();
                        BudgetItem(budgetCategory);
                        break;

                    case ("9"):
                        Console.WriteLine(" ");
                        Console.WriteLine(">>> Heading to main menu. <<<");
                        Console.WriteLine(" ");
                        budgetCategory.DisplayBudgetTotal();
                        budgetCategory.DisplayExpenseTotal();
                        Console.WriteLine(" ");
                        break;

                }

            }



            static void ExpenseItem(BudgetManager budgetCategory)
            {
                Console.WriteLine("Please select an option below and add an EXPENSE category:");
                Console.WriteLine("1) Rent");
                Console.WriteLine("2) Food");
                Console.WriteLine("3) Transportation");
                Console.WriteLine("4) Entertainment");
                Console.WriteLine("5) Shopping");
                Console.WriteLine("6) Add a category");
                Console.WriteLine("7) Edit a category");
                Console.WriteLine("8) Delete a category");
                Console.WriteLine("9) Back to Main Menu");
                Console.WriteLine();

                string response = Console.ReadLine();

                switch (response)
                {
                    case ("1"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddExpenseCategory("Rent", amount);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("2"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount1 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddExpenseCategory("Food", amount1);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("3"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount2 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddExpenseCategory("Transportation", amount2);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("4"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount3 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddExpenseCategory("Entertainment", amount3);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("5"):
                        Console.WriteLine("Please enter amount: ");
                        decimal amount4 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddExpenseCategory("Shopping", amount4);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("6"):
                        Console.WriteLine("Please enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter amount: ");
                        decimal amount5 = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.AddExpenseCategory(name, amount5);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("7"):
                        Console.WriteLine("Please enter category name: ");
                        string oldName = Console.ReadLine();
                        Console.WriteLine("Please enter new category name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Please enter new amount: ");
                        decimal newAmount = Convert.ToDecimal(Console.ReadLine());
                        budgetCategory.EditExpenseCategory(oldName, newName, newAmount);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("8"):
                        Console.WriteLine("Please enter name: ");
                        string name1 = Console.ReadLine();
                        budgetCategory.DeleteExpenseCategory(name1);
                        budgetCategory.DisplayExpenseItems();
                        budgetCategory.DisplayExpenseTotal();
                        ExpenseItem(budgetCategory);
                        break;

                    case ("9"):
                        Console.WriteLine(" ");
                        Console.WriteLine(">>> Heading to main menu. <<<");
                        Console.WriteLine(" ");
                        budgetCategory.DisplayBudgetTotal();
                        budgetCategory.DisplayExpenseTotal();
                        Console.WriteLine(" ");
                        break;

                }

            }


        }   
    }
}

