# **Visual Basic**

```
Visual BasicVisual Basic 6.0 logo.png
Visual Basic 6.0 on Windows XP.png
Visual Basic 6.0 IDE on Windows XP
Paradigm	Object-based and Event-driven
Developer	Microsoft
First appeared	1991; 29 years ago
Stable release	6.0 / 1998; 22 years ago
Typing discipline	Static, strong
OS	Microsoft Windows and MS-DOS
Website	msdn.microsoft.com/en-us/library/windows/desktop/ms788229.aspx
Major implementations
Microsoft Visual Studio
Influenced by BASIC
Influenced Visual Basic .NET, Gambas, Xojo, Basic4ppc and NS Basic
```

## Introduction

Visual Basic is a third-generation event-driven programming language from Microsoft for its Component Object Model (COM) programming model first released in 1991 and declared legacy during 2008. Microsoft intended Visual Basic to be relatively easy to learn and use. Visual Basic was derived from BASIC and enables the rapid application development (RAD) of graphical user interface (GUI) applications, access to databases using Data Access Objects, Remote Data Objects, or ActiveX Data Objects, and creation of ActiveX controls and objects.

A programmer can create an application using the components provided by the Visual Basic program itself. Over time the community of programmers developed third-party components. Programs written in Visual Basic can also use the Windows API, which requires external function declarations.

The final release was version 6 in 1998 (now known simply as Visual Basic). On April 8, 2008, Microsoft stopped supporting Visual Basic 6.0 IDE. The Microsoft Visual Basic team still maintains compatibility for Visual Basic 6.0 applications on Windows Vista, Windows Server 2008 including R2, Windows 7, Windows 8, Windows 8.1, Windows Server 2012, Windows 10, Windows Server 2016, and Windows Server 2019 through its "It Just Works" program. In 2014, some software developers still preferred Visual Basic 6.0 over its successor, Visual Basic .NET. In 2014 some developers lobbied for a new version of the VB6 programming environment. In 2016, Visual Basic 6.0 won the technical impact award at The 19th Annual D.I.C.E. Awards. A dialect of Visual Basic, Visual Basic for Applications (VBA), is used as a macro or scripting language within several Microsoft applications, including Microsoft Office.

## Characteristics

The code windows in Visual Basic, showing a function using the If, Then, Else and Dim statements.

Visual Basic builds upon the characteristics of BASIC.

There are no line numbers as in earlier BASIC, code is grouped into subroutines or methods: Sub...End Sub.

Code Statements have no terminating character other than a line ending (carriage return/line feed). Versions since at least VB 3.0 allowed that statements can be implicitly multi-line with concatenation of strings or explicitly using the underscore character (_) at the end of lines.

Code comments are done with a single apostrophe (') character. ' This is a comment'

Looping statement blocks begin and end with keywords: Do...Loop, While...End While, For...Next .

Multiple variable assignment is not possible. A = B = C does not imply that the values of A, B and C are equal. The Boolean result of "Is B = C?" is stored in A. The result stored in A would therefore be either false or true.

Boolean constant True has numeric value −1. This is because the Boolean data type is stored as a two's complement signed integer. In this construct −1 evaluates to all-1s in binary (the Boolean value True), and 0 as all-0s (the Boolean value False). This is apparent when performing a (bitwise) Not operation on the two's complement value 0, which returns the two's complement value −1, in other words True = Not False. This inherent functionality becomes especially useful when performing logical operations on the individual bits of an integer such as And, Or, Xor and Not. This definition of True is also consistent with BASIC since the early 1970s Microsoft BASIC implementation and is also related to the characteristics of CPU instructions at the time.

Logical and bitwise operators are unified. This is unlike some C-derived languages (such as Perl), which have separate logical and bitwise operators. This again is a traditional feature of BASIC.

Variable array base. Arrays are declared by specifying the upper and lower bounds in a way similar to Pascal and Fortran. It is also possible to use the Option Base statement to set the default lower bound. Use of the Option Base statement can lead to confusion when reading Visual Basic code and is best avoided by always explicitly specifying the lower bound of the array. This lower bound is not limited to 0 or 1, because it can also be set by declaration. In this way, both the lower and upper bounds are programmable. In more subscript-limited languages, the lower bound of the array is not variable. This uncommon trait does exist in Visual Basic .NET but not in VBScript.

OPTION BASE was introduced by ANSI, with the standard for ANSI Minimal BASIC in the late 1970s.

Relatively strong integration with the Windows operating system and the Component Object Model. The native types for strings and arrays are the dedicated COM types, BSTR and SAFEARRAY.

Banker's rounding as the default behavior when converting real numbers to integers with the Round function. Round(2.5, 0) gives 2, ? Round(3.5, 0) gives 4.

Integers are automatically promoted to reals in expressions that involve the normal division operator (/) so that division of one integer by another produces the intuitively correct result. VB provides a specific integer divide operator (\) that does truncate.

By default, if a variable has not been declared or if no type declaration character is specified, the variable is of type Variant. However this can be changed with Deftype statements such as DefInt, DefBool, DefVar, DefObj, DefStr. There are 12 Deftype statements in total offered by Visual Basic 6.0. The default type may be overridden for a specific declaration by using a special suffix character on the variable name (# for Double, ! for Single, & for Long, % for Integer, $ for String, and @ for Currency) or using the key phrase As (type). VB can also be set in a mode that only explicitly declared variables can be used with the command Option Explicit.

# Visual-Basic
