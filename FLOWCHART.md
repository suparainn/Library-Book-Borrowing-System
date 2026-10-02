# Library Book Borrowing System - Program Flowchart

## Main Program Flow

```
┌─────────────────────────────────────────────────────┐
│  START: Library Book Borrowing System               │
│  Platform: Web Platform                             │
└────────────────┬────────────────────────────────────┘
                 │
                 ▼
┌─────────────────────────────────────────────────────┐
│  Display Title and System Description               │
│  - Platform: Web Platform                           │
│  - System: Library Book Borrowing System            │
└────────────────┬────────────────────────────────────┘
                 │
                 ▼
        ┌────────────────────┐
        │  Display Main Menu │
        │  1. AND Gate       │
        │  2. OR Gate        │
        │  3. NOT Gate       │
        │  4. NAND Gate      │
        │  5. NOR Gate       │
        │  6. XOR Gate       │
        │  7. XNOR Gate      │
        │  8. Truth Table    │
        │  9. Exit           │
        └────────┬───────────┘
                 │
                 ▼
        ┌────────────────────┐
        │  Get User Choice   │
        └────────┬───────────┘
                 │
                 ▼
        ┌────────────────────┐
        │  Is Choice = 9?    │
        │  (Exit)            │
        └─┬──────────────┬───┘
          │ YES          │ NO
          │              │
          │              ▼
          │        ┌───────────���──────┐
          │        │  Switch(Choice)  │
          │        └──────┬───────────┘
          │               │
          │    ┌──────────┼──────────┐
          │    │ 1-7 (Logic Gates)   │
          │    │ 8 (Truth Table)     │
          │    │ Default (Invalid)   │
          │    │                     │
          │    ▼─────────────────────┼─────────────┐
          │    │                     │             │
          │    ▼                     ▼             ▼
          │ Run Logic Gate      Show Truth     Invalid
          │ Method              Table          Option
          │    │                 │             │
          │    ▼                 ▼             ▼
          │ (See detailed    Print Truth   Error
          │  flowcharts      Table with    Message
          │  below)          All Gates
          │    │                 │             │
          │    └─────────────────┴─────────────┘
          │                 │
          │                 ▼
          │        ┌────────────────────┐
          │        │  Loop Back to Menu │
          │        └────────────────────┘
          │
          ▼
┌─────────────────────────────────────────────────────┐
│  Display "Thank you for using the system"           │
│  END Program                                        │
└─────────────────────────────────────────────────────┘
```

---

## AND Gate Flowchart

```
┌──────────────────────────┐
│  START: AND Gate         │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input A: Account Active (0 or 1)    │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input B: Book Available (0 or 1)    │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = A AND B             │
│  (Both must be 1 for result to be 1)     │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "Borrow  │  │ "Borrow request      │
    │ approved"│  │ denied. Account must │
    └────┬─────┘  │ be active and book   │
         │        │ must be available."  │
         │        └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result:                          │
│  - Selected Platform: Web Platform        │
│  - System: Library Book Borrowing System  │
│  - Selected Logic Gate: AND               │
│  - Input A: [value]                       │
│  - Input B: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## OR Gate Flowchart

```
┌──────────────────────────┐
│  START: OR Gate          │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input A: Has Library Card (0 or 1)  │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input B: Is Staff Member (0 or 1)   │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = A OR B              │
│  (At least one must be 1)                │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "Access  │  │ "Access denied.      │
    │ granted" │  │ User must have a     │
    └────┬─────┘  │ library card or      │
         │        │ staff status."       │
         │        └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result                           │
│  - Input A: [value]                       │
│  - Input B: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## NOT Gate Flowchart

```
┌──────────────────────────┐
│  START: NOT Gate         │
└────────────┬─────────────┘
             │
             ▼
┌─────────────────────────────────────────────┐
│  Get Input A: Overdue Status (0 or 1)       │
│  (1 = overdue, 0 = not overdue)             │
│  Loop until valid input                     │
└────────────┬────────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = NOT A               │
│  (Reverse the input value)               │
│  If A = 0, Result = 1                    │
│  If A = 1, Result = 0                    │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "User is │  │ "User is overdue.    │
    │ not      │  │ Borrowing is not     │
    │ overdue" │  │ allowed."            │
    └────┬─────┘  └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result                           │
│  - Input A: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## NAND Gate Flowchart

```
┌──────────────────────────┐
│  START: NAND Gate        │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input A: Account Active (0 or 1)    │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input B: Book Available (0 or 1)    │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = NOT(A AND B)        │
│  (Opposite of AND)                       │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "Not     │  │ "The AND condition   │
    │ (Account │  │ was true."           │
    │ AND Book)│  │                      │
    │ is true" │  │                      │
    └────┬─────┘  └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result                           │
│  - Input A: [value]                       │
│  - Input B: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## NOR Gate Flowchart

```
┌──────────────────────────┐
│  START: NOR Gate         │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input A: Membership Valid (0 or 1)  │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input B: Book Reserved (0 or 1)     │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = NOT(A OR B)         │
│  (Opposite of OR)                        │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "Neither │  │ "At least one        │
    │ condition│  │ condition is true."  │
    │ is true" │  │                      │
    └────┬─────┘  └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result                           │
│  - Input A: [value]                       │
│  - Input B: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## XOR Gate Flowchart

```
┌──────────────────────────┐
│  START: XOR Gate         │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input A: Account Verified (0 or 1)  │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input B: ID Verified (0 or 1)       │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = A XOR B             │
│  (True if A and B are different)         │
│  If A ≠ B, Result = 1                    │
│  If A = B, Result = 0                    │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "One of  │  │ "Both conditions     │
    │ the      │  │ are the same."       │
    │ conditions│ │                      │
    │ is true" │  │                      │
    └────┬─────┘  └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result                           │
│  - Input A: [value]                       │
│  - Input B: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## XNOR Gate Flowchart

```
┌──────────────────────────┐
│  START: XNOR Gate        │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input A: Membership Valid (0 or 1)  │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Get Input B: Payment Updated (0 or 1)   │
│  Loop until valid input                  │
└────────────┬─────────────────────────────┘
             │
             ▼
┌──────────────────────────────────────────┐
│  Calculate: Result = A XNOR B            │
│  (True if A and B are same)              │
│  If A = B, Result = 1                    │
│  If A ≠ B, Result = 0                    │
└────────────┬─────────────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Result = 1?    │
        └─┬───────────┬───┘
          │ YES       │ NO
          │           │
          ▼           ▼
    ┌──────────┐  ┌──────────────────────┐
    │ Decision │  │ Decision             │
    │ "Both    │  │ "Conditions do not   │
    │ conditions│ │ match."              │
    │ match"   │  │                      │
    └────┬─────┘  └──────────┬───────────┘
         │                   │
         └───────┬───────────┘
                 │
                 ▼
┌───────────────────────────────────────────┐
│  Display Result                           │
│  - Input A: [value]                       │
│  - Input B: [value]                       │
│  - Logic Gate Result: [1 or 0]            │
│  - System Decision: [decision message]    │
└───────────────────┬───────────────────────┘
                    │
                    ▼
        ┌────────────────────────┐
        │  Return to Main Menu   │
        └────────────────────────┘
```

---

## Input Validation Flowchart

```
┌─────────────────────────────────┐
│  START: Get Binary Input        │
│  GetBinaryInput(prompt)         │
└────────────┬────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  Loop Start     │
        └────────┬────────┘
                 │
                 ▼
    ┌────────────────────────────┐
    │  Display Prompt            │
    │  "Enter value (0 or 1):"   │
    └────────┬───────────────────┘
             │
             ▼
    ┌────────────────────────────┐
    │  Read User Input           │
    └────────┬───────────────────┘
             │
             ▼
        ┌────────────────────┐
        │  Is input = "0"    │
        │  or "1"?           │
        └─┬──────────────┬───┘
          │ YES          │ NO
          │              │
          ▼              ▼
    ┌──────────┐   ┌──────────────────────┐
    │ Return   │   │ Display Error Msg:   │
    │ Value    │   │ "Invalid input!      │
    │ (0 or 1) │   │ Please enter 0 or 1"│
    └──────────┘   └──────┬───────────────┘
         │                │
         │                ▼
         │           ┌─────────────────┐
         │           │  Loop Back      │
         │           └────────┬────────┘
         │                    │
         └────────┬───────────┘
                  │
                  ▼
         ┌────────────────────┐
         │  END: Return Value │
         └────────────────────┘
```

---

## Truth Table Display Flowchart

```
┌──────────────────────────┐
│  START: Show Truth Table │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────────────┐
│  Display Header:                 │
│  "TRUTH TABLE FOR ALL SEVEN      │
│  LOGIC GATES"                    │
└────────────┬─────────────────────┘
             │
             ▼
┌──────────────────────────────────┐
│  Display Column Headers:         │
│  "A  B  AND OR NOT(A) NAND NOR   │
│  XOR XNOR"                       │
└────────────┬─────────────────────┘
             │
             ▼
        ┌─────────────────┐
        │  For A = 0, 1   │
        └────────┬────────┘
                 │
                 ▼
            ┌─────────────────┐
            │  For B = 0, 1   │
            └────────┬────────┘
                     │
                     ▼
        ┌────────────────────────────┐
        │  Calculate all 7 gates:    │
        │  - AND = A & B             │
        │  - OR = A | B              │
        │  - NOT = !A                │
        │  - NAND = !(A & B)         │
        │  - NOR = !(A | B)          │
        │  - XOR = A ≠ B             │
        │  - XNOR = A = B            │
        └────────┬───────────────────┘
                 │
                 ▼
        ┌────────────────────────────┐
        │  Display Row:              │
        │  A B AND OR NOT NAND NOR   │
        │  XOR XNOR [calculated vals]│
        └────────┬───────────────────┘
                 │
                 ▼
        ┌────────────────────┐
        │  All rows done?    │
        │  (4 rows total)    │
        └─┬──────────────┬───┘
          │ YES          │ NO
          │              │
          │              ▼
          │         ┌─────────────────┐
          │         │  Loop to next B │
          │         └────────┬────────┘
          │                  │
          └──────┬───────────┘
                 │
                 ▼
        ┌────────────────────────┐
        │  Display Footer        │
        │  "========"            │
        └────────┬───────────────┘
                 │
                 ▼
        ┌────────────────────┐
        │  Return to Menu    │
        └────────────────────┘
```

---

## Summary

This flowchart shows:

1. **Main Menu Loop**: The program keeps showing the menu until the user chooses Exit (9)
2. **Input Validation**: Only accepts 0 or 1
3. **Each Gate Logic**: How each gate calculates its result
4. **Decision Making**: How results lead to system decisions
5. **Truth Table**: How all 7 gates are calculated and displayed
6. **Loop Control**: Program repeats until Exit is selected

All flowcharts use standard flowchart symbols:
- **Rectangles** = Process/Action
- **Diamonds** = Decision/Question
- **Ovals** = Start/End
- **Arrows** = Flow direction

This visual representation makes it easy to understand the program flow for your midterm project presentation!
