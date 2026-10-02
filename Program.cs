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
            Console.WriteLine("1. Borrowing Approval");
            Console.WriteLine("2. Library Access Control");
            Console.WriteLine("3. Overdue Check");
            Console.WriteLine("4. Security Lock");
            Console.WriteLine("5. Restricted Access Check");
            Console.WriteLine("6. Verification Check");
            Console.WriteLine("7. Payment Consistency Check");
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
                    BorrowingApprovalFeature();
                    break;
                case 2:
                    LibraryAccessFeature();
                    break;
                case 3:
                    OverdueCheckFeature();
                    break;
                case 4:
                    SecurityLockFeature();
                    break;
                case 5:
                    RestrictedAccessFeature();
                    break;
                case 6:
                    VerificationFeature();
                    break;
                case 7:
                    PaymentConsistencyFeature();
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
            Console.Write(message + " (Enter 0 or 1): ");
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

    static void ShowFeatureResult(string featureName, string featureDescription, int a, int b, int result, string decision)
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("Selected Computing Platform: Web Platform");
        Console.WriteLine("System: Library Book Borrowing System");
        Console.WriteLine("Feature: " + featureName);
        Console.WriteLine("Description: " + featureDescription);
        Console.WriteLine("Input A: " + a);
        Console.WriteLine("Input B: " + b);
        Console.WriteLine("Result: " + result);
        Console.WriteLine("System Decision: " + decision);
        Console.WriteLine("========================================");
    }

    // Feature 1: Borrowing Approval -> uses AND
    static void BorrowingApprovalFeature()
    {
        int accountActive = GetBinaryInput("Account Active");
        int bookAvailable = GetBinaryInput("Book Available");

        int result = AndGate(accountActive, bookAvailable);

        string decision = (result == 1)
            ? "Borrow approved. Student can borrow the book."
            : "Borrow denied. Account must be active and the book must be available.";

        ShowFeatureResult("Borrowing Approval", "A student can borrow only when the account is active and the book is available.", accountActive, bookAvailable, result, decision);
    }

    // Feature 2: Library Access Control -> uses OR
    static void LibraryAccessFeature()
    {
        int hasLibraryCard = GetBinaryInput("Has Library Card");
        int isStaff = GetBinaryInput("Is Staff Member");

        int result = OrGate(hasLibraryCard, isStaff);

        string decision = (result == 1)
            ? "Library access granted. User has a library card or staff access."
            : "Library access denied. User must have either a library card or staff status.";

        ShowFeatureResult("Library Access Control", "A user can access library services if they have a library card or are staff.", hasLibraryCard, isStaff, result, decision);
    }

    // Feature 3: Overdue Check -> uses NOT
    static void OverdueCheckFeature()
    {
        int overdue = GetBinaryInput("Overdue Status");

        int result = NotGate(overdue);

        string decision = (result == 1)
            ? "User is not overdue. Borrowing is allowed."
            : "User is overdue. Borrowing is not allowed.";

        ShowFeatureResult("Overdue Check", "A user may borrow only if they are not overdue.", overdue, 0, result, decision);
    }

    // Feature 4: Security Lock -> uses NAND
    static void SecurityLockFeature()
    {
        int accountActive = GetBinaryInput("Account Active");
        int bookAvailable = GetBinaryInput("Book Available");

        int result = NandGate(accountActive, bookAvailable);

        string decision = (result == 1)
            ? "Security override allowed. Borrowing under restricted mode is not blocked."
            : "Security lock triggered. Borrowing is blocked because the system detected a protected condition.";

        ShowFeatureResult("Security Lock", "Emergency library security checks block borrowing when both conditions are active in a restricted system.", accountActive, bookAvailable, result, decision);
    }

    // Feature 5: Restricted Access Check -> uses NOR
    static void RestrictedAccessFeature()
    {
        int membershipValid = GetBinaryInput("Membership Valid");
        int reservationActive = GetBinaryInput("Reservation Active");

        int result = NorGate(membershipValid, reservationActive);

        string decision = (result == 1)
            ? "Restricted access triggered. User is denied because both conditions are false."
            : "Access allowed. At least one condition is valid.";

        ShowFeatureResult("Restricted Access Check", "The system denies access if neither membership is valid nor reservation is active.", membershipValid, reservationActive, result, decision);
    }

    // Feature 6: Verification Check -> uses XOR
    static void VerificationFeature()
    {
        int accountVerified = GetBinaryInput("Account Verified");
        int idVerified = GetBinaryInput("ID Verified");

        int result = XorGate(accountVerified, idVerified);

        string decision = (result == 1)
            ? "Verification succeeded. Exactly one method is true."
            : "Verification failed. Both conditions are the same or neither is true.";

        ShowFeatureResult("Verification Check", "For special borrowing cases, exactly one verification method should be true.", accountVerified, idVerified, result, decision);
    }

    // Feature 7: Payment Consistency Check -> uses XNOR
    static void PaymentConsistencyFeature()
    {
        int membershipValid = GetBinaryInput("Membership Valid");
        int paymentUpdated = GetBinaryInput("Payment Updated");

        int result = XnorGate(membershipValid, paymentUpdated);

        string decision = (result == 1)
            ? "Payment and membership are consistent. System status is valid."
            : "Payment and membership are inconsistent. User must fix their records.";

        ShowFeatureResult("Payment Consistency Check", "Membership and payment status should match. Both must be valid or both must be invalid.", membershipValid, paymentUpdated, result, decision);
    }

    // Truth Table for all 7 logic gates
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
