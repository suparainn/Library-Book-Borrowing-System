using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine(" WEB PLATFORM: LIBRARY BOOK BORROWING SYSTEM");
        Console.WriteLine("========================================");
        Console.WriteLine("Platform: Web Platform");
        Console.WriteLine("System: Library Book Borrowing System");
        Console.WriteLine("Description: A library website checks whether a user can borrow a book.");
        Console.WriteLine("========================================");

        int choice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. AND Gate");
            Console.WriteLine("2. OR Gate");
            Console.WriteLine("3. NOT Gate");
            Console.WriteLine("4. NAND Gate");
            Console.WriteLine("5. NOR Gate");
            Console.WriteLine("6. XOR Gate");
            Console.WriteLine("7. XNOR Gate");
            Console.WriteLine("8. Show Truth Table");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
                choice = 0;
                continue;
            }

            switch (choice)
            {
                case 1:
                    RunAndGate();
                    break;
                case 2:
                    RunOrGate();
                    break;
                case 3:
                    RunNotGate();
                    break;
                case 4:
                    RunNandGate();
                    break;
                case 5:
                    RunNorGate();
                    break;
                case 6:
                    RunXorGate();
                    break;
                case 7:
                    RunXnorGate();
                    break;
                case 8:
                    ShowTruthTable();
                    break;
                case 9:
                    Console.WriteLine("Thank you for using the Library Book Borrowing System. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1 to 9.");
                    break;
            }

        } while (choice != 9);
    }

    static int GetBinaryInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt + " (Enter 0 or 1): ");
            string input = Console.ReadLine();

            if (input == "0" || input == "1")
            {
                return int.Parse(input);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter only 0 or 1.");
            }
        }
    }

    static int AndGate(int a, int b)
    {
        return a & b;
    }

    static int OrGate(int a, int b)
    {
        return a | b;
    }

    static int NotGate(int a)
    {
        return a == 0 ? 1 : 0;
    }

    static int NandGate(int a, int b)
    {
        return NotGate(AndGate(a, b));
    }

    static int NorGate(int a, int b)
    {
        return NotGate(OrGate(a, b));
    }

    static int XorGate(int a, int b)
    {
        return a != b ? 1 : 0;
    }

    static int XnorGate(int a, int b)
    {
        return a == b ? 1 : 0;
    }

    static void ShowGateResult(string gateName, int a, int b, int result, string decision)
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("Selected Platform: Web Platform");
        Console.WriteLine("System: Library Book Borrowing System");
        Console.WriteLine("Selected Logic Gate: " + gateName);
        Console.WriteLine("Input A: " + a);
        Console.WriteLine("Input B: " + b);
        Console.WriteLine("Logic Gate Result: " + result);
        Console.WriteLine("System Decision: " + decision);
        Console.WriteLine("========================================");
    }

    static void RunAndGate()
    {
        int accountActive = GetBinaryInput("Account Active");
        int bookAvailable = GetBinaryInput("Book Available");

        int result = AndGate(accountActive, bookAvailable);

        string decision = (result == 1)
            ? "Borrow request approved. The student can borrow the book."
            : "Borrow request denied. Account must be active and the book must be available.";

        ShowGateResult("AND", accountActive, bookAvailable, result, decision);
    }

    static void RunOrGate()
    {
        int hasLibraryCard = GetBinaryInput("Has Library Card");
        int isStaff = GetBinaryInput("Is Staff Member");

        int result = OrGate(hasLibraryCard, isStaff);

        string decision = (result == 1)
            ? "Access granted. The user has a library card or staff access."
            : "Access denied. The user must have either a library card or staff status.";

        ShowGateResult("OR", hasLibraryCard, isStaff, result, decision);
    }

    static void RunNotGate()
    {
        int overdueStatus = GetBinaryInput("Overdue Status (1 = overdue, 0 = not overdue)");

        int result = NotGate(overdueStatus);

        string decision = (result == 1)
            ? "The user is not overdue. Borrowing is allowed."
            : "The user is overdue. Borrowing is not allowed.";

        ShowGateResult("NOT", overdueStatus, 0, result, decision);
    }

    static void RunNandGate()
    {
        int accountActive = GetBinaryInput("Account Active");
        int bookAvailable = GetBinaryInput("Book Available");

        int result = NandGate(accountActive, bookAvailable);

        string decision = (result == 1)
            ? "NOT (Account Active AND Book Available) is true. Borrowing is not allowed under the normal rule."
            : "The AND condition was true, so the NAND result is 0.";

        ShowGateResult("NAND", accountActive, bookAvailable, result, decision);
    }

    static void RunNorGate()
    {
        int membershipValid = GetBinaryInput("Membership Valid");
        int reservationActive = GetBinaryInput("Reservation Active");

        int result = NorGate(membershipValid, reservationActive);

        string decision = (result == 1)
            ? "Neither membership nor reservation is valid. Access is restricted."
            : "At least one condition is true, so access is not fully restricted.";

        ShowGateResult("NOR", membershipValid, reservationActive, result, decision);
    }

    static void RunXorGate()
    {
        int accountVerified = GetBinaryInput("Account Verified");
        int idVerified = GetBinaryInput("ID Verified");

        int result = XorGate(accountVerified, idVerified);

        string decision = (result == 1)
            ? "Only one verification condition is true. Verification status is mixed."
            : "Both verification conditions are the same. Verification status is consistent.";

        ShowGateResult("XOR", accountVerified, idVerified, result, decision);
    }

    static void RunXnorGate()
    {
        int membershipValid = GetBinaryInput("Membership Valid");
        int paymentUpdated = GetBinaryInput("Payment Updated");

        int result = XnorGate(membershipValid, paymentUpdated);

        string decision = (result == 1)
            ? "Both conditions match. Borrowing process is valid and consistent."
            : "The conditions do not match. Borrowing process is inconsistent.";

        ShowGateResult("XNOR", membershipValid, paymentUpdated, result, decision);
    }

    static void ShowTruthTable()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("TRUTH TABLE FOR ALL SEVEN LOGIC GATES");
        Console.WriteLine("========================================");
        Console.WriteLine("A   B   AND  OR  NOT(A) NAND NOR XOR XNOR");
        Console.WriteLine("----------------------------------------");

        int[] values = { 0, 1 };

        foreach (int a in values)
        {
            foreach (int b in values)
            {
                int andResult = AndGate(a, b);
                int orResult = OrGate(a, b);
                int notA = NotGate(a);
                int nandResult = NandGate(a, b);
                int norResult = NorGate(a, b);
                int xorResult = XorGate(a, b);
                int xnorResult = XnorGate(a, b);

                Console.WriteLine($"{a}   {b}   {andResult}    {orResult}   {notA}     {nandResult}   {norResult}   {xorResult}   {xnorResult}");
            }
        }

        Console.WriteLine("========================================");
    }
}
