using System;
namespace CourseAssignment
{
	public class BudgetManager: Budget
	{
		private List<Budget> BudgetItems;
		private List<Expense> ExpenseItems;
        

        public BudgetManager()
        {
            BudgetItems = new List<Budget>();
            ExpenseItems = new List<Expense>();
          
        }


        //Income
        //public void EnterIncome()
        //{
        //    decimal income;

        //    while (true)
        //    {
        //        Console.WriteLine("Enter your Income:");
        //        string userInput = Console.ReadLine();

        //        if (decimal.TryParse(userInput, out income))
        //        {
        //            Console.WriteLine($"Income entered: £{income}");
        //            Console.WriteLine();
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid income amount.");
        //            Console.WriteLine();
        //        }
        //    }
        //}



        //METHODS INVOLVING THE BUDGET

        //Adding a budget Category and Amount
        public bool AddBudgetCategory(string name, decimal amount)
        {

             foreach (Budget item in BudgetItems)
             {
                 if(item.GetName() == name)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(">>> >> Category Already Exist!!! << <<<");
                    Console.WriteLine(" ");
                    return false;
                }
             }
             Budget budget = new Budget(name, amount);
             BudgetItems.Add(budget);
            Console.WriteLine(" ");
            Console.WriteLine(">>> >> Category Added Successfully << <<<");
            Console.WriteLine(" ");
            return true;

        }

        //Editing a budget Category and Amount
        public bool EditBudgetCategory(string oldName, string newName, decimal newAmount)
        {
            foreach (Budget item in BudgetItems)
            {
                if (item.GetName() == oldName)
                {
                    item.SetName(newName);
                    item.SetAmount(newAmount);
                    Console.WriteLine(">>>  Category Name and Amount Updated <<<");
                    return true;
                }
            }

            Console.WriteLine(">>> Category Name and Amount not found <<<");
            return false;
        }


        //Deleting a budget Category
        public bool DeleteBudgetCategory(string name)
        {
            foreach (Budget item in BudgetItems)
            {
                if(item.GetName() == name)
                {
                    BudgetItems.Remove(item);
                    Console.WriteLine(" ");
                    Console.WriteLine("--- Category deleted successfully ---");
                    Console.WriteLine(" ");
                    return true;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(">>> >> No record found for the category selected << <<<");
            Console.WriteLine(" ");
            return false;

        }


        //Displaying the list of categories and amounts in a budget list
        public void DisplayBudgetItems()
        {

            Console.WriteLine("Budget List");

            foreach (Budget items in BudgetItems)
            {
                Console.WriteLine($"Category Name: {items.GetName()}, Category Amount: £{items.GetAmount()}");
            }

            Console.WriteLine(" ");
        }


        //Displaying the total amount in the budget list
        public decimal DisplayBudgetTotal()
        {
            decimal totalBudget = 0;

            foreach (Budget item in BudgetItems)
            {
                totalBudget += item.GetAmount();
               
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Total Budget Amount = £{totalBudget}");

            return totalBudget;
        }



        //METHODS INVOLVING THE EXPENSES

        //Adding an expense Category and Amount
        public bool AddExpenseCategory(string name, decimal amount)
        {

            foreach (Expense item in ExpenseItems)
            {
                if (item.GetName() == name)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(">>> >> Category Already Exist!!! << <<<");
                    Console.WriteLine(" ");
                    return false;
                }
            }
            Expense expense = new Expense(name, amount);
            ExpenseItems.Add(expense);
            Console.WriteLine(" ");
            Console.WriteLine(">>> >> Category Added Successfully << <<<");
            Console.WriteLine(" ");
            return true;

        }

        //Editing an expense Category and Amount
        public bool EditExpenseCategory(string oldName, string newName, decimal newAmount)
        {
            foreach (Expense item in ExpenseItems)
            {
                if (item.GetName() == oldName)
                {
                    item.SetName(newName);
                    item.SetAmount(newAmount);
                    Console.WriteLine(">>>  Category Name and Amount Updated <<<");
                    return true;
                }
            }

            Console.WriteLine(">>> Category Name and Amount not found <<<");
            return false;
        }

        //Deleting an expense Category
        public bool DeleteExpenseCategory(string name)
        {
            foreach (Expense item in ExpenseItems)
            {
                if (item.GetName() == name)
                {
                    BudgetItems.Remove(item);
                    Console.WriteLine(" ");
                    Console.WriteLine("--- Category deleted successfully ---");
                    Console.WriteLine(" ");
                    return true;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(">>> >> No record found for the category selected << <<<");
            Console.WriteLine(" ");
            return false;

        }

        //Displaying the list of categories and amounts in an expense list
        public void DisplayExpenseItems()
        {
            Console.WriteLine("Expense List");

            foreach (Budget items in ExpenseItems)
            {
                Console.WriteLine($"Category Name: {items.GetName()}, Category Amount: £{items.GetAmount()}");
            }

            Console.WriteLine(" ");
        }


        //Displaying the total amount in the expense list
        public decimal DisplayExpenseTotal()
        {
            decimal totalExpense = 0;

            foreach (Expense item in ExpenseItems)
            {
                totalExpense += item.GetAmount();
                
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Total Expense Amount = £{totalExpense}");
            Console.WriteLine(" ");

            return totalExpense;
        }




        //Overview

        //Calculating the diffence between the total budget amount and the expenses
        public void DisplayBudgetExpenseDiff()
        {
            decimal difference = 0;
            decimal perdiff = 0;
            decimal tBudget = DisplayBudgetTotal();
            decimal tExpense = DisplayExpenseTotal();


            if (tBudget != 0 && tExpense != 0)
            {
                difference = tBudget - tExpense;

                perdiff = (Math.Abs(difference) / tBudget) * 100;

                Console.WriteLine(" ");
                Console.WriteLine($"The Difference between the budget and Enpense = £{Math.Abs(difference)}");
                Console.WriteLine(" ");

                if (difference >= 0)
                {
                    Console.WriteLine($"KUDOS! You are well within your budget.You've saved up £{Math.Abs(difference)} extra.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Unfortunately, your expenses is £{Math.Abs(difference)} more than your budget.");
                    Console.WriteLine($"You spent {perdiff}% more than your budget.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(" ERROR!!! Unable to calculate difference. Check to see that you have at least a category and amount in your Budget List and Expense List");
            }

            

        }

    }
}

