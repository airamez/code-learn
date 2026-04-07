# Machine Code Example for C# Program

## Original C# Code:
```csharp
Console.WriteLine("Hello World");
decimal price = 10.50m;
decimal tax_percentage = 12m;
decimal total = price + (price * tax_percentage / 100);
Console.WriteLine($"Total: {total}");
```

## IL (Intermediate Language) Bytecode:
```
IL_0000: ldstr "Hello World"                           // Load string "Hello World" onto the stack
IL_0005: call System.Console.WriteLine(string)         // Call WriteLine method with string parameter
IL_000a: ldc.i4 1050                                   // Load integer 1050 (10.50 * 100) onto the stack
IL_000f: newobj System.Decimal..ctor(int)              // Create new Decimal object from int on stack
IL_0014: stloc.0                                       // Store Decimal in local variable 0 (price)
IL_0015: ldc.i4 12                                     // Load integer 12 onto the stack
IL_001a: newobj System.Decimal..ctor(int)              // Create new Decimal object from int on stack
IL_001f: stloc.1                                       // Store Decimal in local variable 1 (tax_percentage)
IL_0020: ldloc.0                                       // Load local variable 0 (price) onto the stack
IL_0021: ldloc.0                                       // Load local variable 0 (price) onto the stack again
IL_0022: ldloc.1                                       // Load local variable 1 (tax_percentage) onto the stack
IL_0023: mul                                           // Multiply the top two values (price * tax_percentage)
IL_0024: ldc.i4 100                                    // Load integer 100 onto the stack
IL_0029: newobj System.Decimal..ctor(int)              // Create new Decimal object from int on stack
IL_002e: div                                           // Divide the top two values (result / 100)
IL_002f: add                                           // Add the top two values (price + tax_amount)
IL_0030: stloc.2                                       // Store result in local variable 2 (total)
IL_0031: ldstr "Total: {0}"                            // Load format string onto the stack
IL_0036: ldloc.2                                       // Load local variable 2 (total) onto the stack
IL_0037: box System.Decimal                            // Box the Decimal value as an object (for string formatting)
IL_003c: call System.Console.WriteLine(string, object) // Call WriteLine with format string and object parameter
IL_0041: ret                                           // Return from the method
```

## Actual Machine Code (x86-64) - JIT Compiled:
```
; Console.WriteLine("Hello World")
48 8D 0D 1A 20 00 00    lea rcx, [rip+0x201a]      ; Load string address
E8 C5 FF FF FF           call <Console.WriteLine>  ; Call WriteLine function

; decimal price = 10.50m
48 8B 4C 24 20           mov rcx, [rsp+0x20]       ; Load decimal constant
48 89 4C 24 30           mov [rsp+0x30], rcx       ; Store price variable

; decimal tax_percentage = 12m
48 8B 4C 24 28           mov rcx, [rsp+0x28]       ; Load decimal constant
48 89 4C 24 40           mov [rsp+0x40], rcx       ; Store tax_percentage

; price * tax_percentage
48 8B 4C 24 30           mov rcx, [rsp+0x30]       ; Load price
48 8B 54 24 40           mov rdx, [rsp+0x40]       ; Load tax_percentage
E8 B0 FF FF FF           call <Decimal.Multiply>   ; Multiply decimals

; Divide by 100
48 8B 4C 24 50           mov rcx, [rsp+0x50]       ; Load result
48 8B 54 24 58           mov rdx, [rsp+0x58]       ; Load 100 decimal
E8 A0 FF FF FF           call <Decimal.Divide>     ; Divide by 100

; Add to original price
48 8B 4C 24 30           mov rcx, [rsp+0x30]       ; Load original price
48 8B 54 24 60           mov rdx, [rsp+0x60]       ; Load multiplication result
E8 90 FF FF FF           call <Decimal.Add>        ; Add decimals
48 89 4C 24 70           mov [rsp+0x70], rcx       ; Store total

; Console.WriteLine($"Total: {total}")
48 8D 0D 05 20 00 00    lea rcx, [rip+0x2005]      ; Load format string
48 8B 54 24 70           mov rdx, [rsp+0x70]       ; Load total
E8 80 FF FF FF           call <Console.WriteLine>  ; Call WriteLine with formatting

C3                       ret                       ; Return from function
```

## Key Machine Code Instructions Explained:

1. **48 8D 0D 1A 20 00 00** - `LEA` (Load Effective Address): Loads the address of the string "Hello World" into RCX register
2. **E8 C5 FF FF FF** - `CALL`: Calls the Console.WriteLine method
3. **48 8B 4C 24 30** - `MOV`: Moves data from stack memory to RCX register (loads price)
4. **48 89 4C 24 30** - `MOV`: Stores data from RCX register to stack memory (stores price)
5. **E8 B0 FF FF FF** - `CALL`: Calls the Decimal.Multiply method
6. **E8 A0 FF FF FF** - `CALL`: Calls the Decimal.Divide method  
7. **E8 90 FF FF FF** - `CALL`: Calls the Decimal.Add method
8. **C3** - `RET`: Returns from the function