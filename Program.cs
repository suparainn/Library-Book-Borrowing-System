using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("WEB PLATFORM: LIBRARY BOOK BORROWING SYSTEM");
        Console.WriteLine("========================================");
        Console.WriteLine("Project Title: Library Book Borrowing System");
        Console.WriteLine("Selected Computing Platform: Web Platform");
        Console.WriteLine("System: Library Book Borrowing System");
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
                    AndGateMenu();
                    break;
                case 2:
                    OrGateMenu();
                    break;
                case 3:
                    NotGateMenu();
                    break;
                case 4:
                    NandGateMenu();
                    break;
                case 5:
                    NorGateMenu();
                    break;
                case 6:
                    XorGateMenu();
                    break;
                case 7:
                    XnorGateMenu();
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

    static int GetBinaryInput(string message)
    {
        while (true)
        {
            Console.Write(message + " (0 or 1): ");
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

    static void ShowResult(string gateName, int a, int b, int result, string decision)
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("Selected Computing Platform: Web Platform");
        Console.WriteLine("System: Library Book Borrowing System");
        Console.WriteLine("Selected Logic Gate: " + gateName);
        Console.WriteLine("Input A: " + a);
        Console.WriteLine("Input B: " + b);
        Console.WriteLine("Logic Gate Result: " + result);
        Console.WriteLine("System Decision: " + decision);
        Console.WriteLine("========================================");
    }

    static void AndGateMenu()
    {
        int accountActive = GetBinaryInput("Account Active");
        int bookAvailable = GetBinaryInput("Book Available");

        int result = AndGate(accountActive, bookAvailable);

        string decision = (result == 1)
            ? "BORROW APPROVED. The student can borrow the book."
            : "BORROW DENIED. The account must be active and the book must be available.";

        ShowResult("AND", accountActive, bookAvailable, result, decision);
    }

    static void OrGateMenu()
    {
        int hasLibraryCard = GetBinaryInput("Has Library Card");
        int isStaff = GetBinaryInput("Is Staff Member");

        int result = OrGate(hasLibraryCard, isStaff);

        string decision = (result == 1)
            ? "ACCESS GRANTED. The user has a library card or staff access."
            : "ACCESS DENIED. The user must have either a library card or staff status.";

        ShowResult("OR", hasLibraryCard, isStaff, result, decision);
    }

    static void NotGateMenu()
    {
        int overdue = GetBinaryInput("Overdue Status");

        int result = NotGate(overdue);

        string decision = (result == 1)
            ? "NOT OVERDUE. Borrowing is allowed."
            : "OVERDUE. Borrowing is not allowed.";

        ShowResult("NOT", overdue, 0, result, decision);
    }

    static void NandGateMenu()
    {
        int accountActive = GetBinaryInput("Account Active");
        int bookAvailable = GetBinaryInput("Book Available");

        int result = NandGate(accountActive, bookAvailable);

        string decision = (result == 1)
            ? "NOT (Account Active AND Book Available) is true. Borrowing is not allowed under the normal rule."
            : "The AND condition was true, so the NAND result is 0.";

        ShowResult("NAND", accountActive, bookAvailable, result, decision);
    }

    static void NorGateMenu()
    {
        int membershipValid = GetBinaryInput("Membership Valid");
        int reservationActive = GetBinaryInput("Reservation Active");

        int result = NorGate(membershipValid, reservationActive);

        string decision = (result == 1)
            ? "NEITHER condition is valid. Access is restricted."
            : "At least one condition is true, so access is not fully restricted.";

        ShowResult("NOR", membershipValid, reservationActive, result, decision);
    }

    static void XorGateMenu()
    {
        int accountVerified = GetBinaryInput("Account Verified");
        int idVerified = GetBinaryInput("ID Verified");

        int result = XorGate(accountVerified, idVerified);

        string decision = (result == 1)
            ? "ONLY ONE verification condition is true. The verification status is mixed."
            : "Both verification conditions are the same. Verification status is consistent.";

        ShowResult("XOR", accountVerified, idVerified, result, decision);
    }

    static void XnorGateMenu()
    {
        int membershipValid = GetBinaryInput("Membership Valid");
        int paymentUpdated = GetBinaryInput("Payment Updated");

        int result = XnorGate(membershipValid, paymentUpdated);

        string decision = (result == 1)
            ? "Both conditions match. Borrowing process is valid and consistent."
            : "The conditions do not match. Borrowing process is inconsistent.";

        ShowResult("XNOR", membershipValid, paymentUpdated, result, decision);
    }

    static void ShowTruthTable()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("TRUTH TABLE FOR ALL SEVEN LOGIC GATES");
        Console.WriteLine("========================================");
        Console.WriteLine("A   B   AND  OR  NOT(A) NAND NOR XOR XNOR");
        Console.WriteLine("----------------------------------------");

        for (int a = 0; a <= 1; a++)
        {
            for (int b = 0; b <= 1; b++)
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
