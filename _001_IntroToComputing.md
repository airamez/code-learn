# Intro to computing
  * Abstraction
    * What is abstraction?
    * Why is abstraction important?
    * It is all a ilusion
    * Without abstraction we can't understand, build, operate, and maintain complex systems
    * Almost everything has layers and layers of abstractions
  * How a computer stores information
    * Example:
      * Teenagers dating code
        * Using lights at windows to indicate status
          * One light
          * Two lights
          * Three or more lights?
      * [Teenagers dating code example](excalidraw/_01_TeenagersCodes.png)
    * Numeric Systems
      *Binary
        * Base 2 number system
        * Only uses 0 and 1
        * Example: 1011 in binary is 11 in decimal
        * How to convert to and from decimal to binary?
      * Octal
        * Base 8 number system
        * Uses 0-7
        * Example: 123 in octal is 1010011 in binary
        * How to convert to and from decimal to octal?
      * Hexadecimal
        * Base 16 number system
        * Uses 0-9 and A-F
        * Example: 1A3 in hexadecimal is 110100011 in binary
        * How to convert to and from decimal to hexadecimal?
    * Data, Information, Bit and Byte
      * Kilo: 1024 Bytes
      * Mega: 1024 Kilo
      * Giga: 1024 Mega
      * Tera: 1024 Giga
      * Peta: 1024 Tera
      * Exa: 1024 Peta
      * Zetta: 1024 Exa
      * Yotta: 1024 Zetta
      * Why 1024: Because it's 2^10, which is a power of 2, and computers work in binary
  * How Computers Store Different Types of Information
    * Everything is stored as binary (0s and 1s).
    * All these types of data are just numbers, stored as bits/bytes — the format / encoding tells software how to interpret the bits.
    * Text
      * Each character is mapped to a number
      * ASCII
        * American Standard Code for Information Interchange, is a character encoding standard for representing a particular set of 95 (English language focused) printable and 33 control characters – a total of 128 code points.
        * https://en.wikipedia.org/wiki/ASCII
        * https://www.ascii-code.com/
        * The first convention globally used to map characters to numbers
        * Example: Love (76 111 118 101)
          * L = 76
          * o = 111
          * v = 118
          * e = 101
      * Unicode
        * A universal *standard* that assigns a unique number (code point) to every character across all languages, symbols, and emoji
        * https://unicode.org/charts/
        * Covers over 140,000 characters — far beyond ASCII's 128
      * UTF-8
        * An *encoding* — defines how to store Unicode code points as bytes
        * Uses 1 to 4 bytes per character
        * Backward-compatible with ASCII (first 128 characters are identical)
        * The most widely used encoding on the web
        * Example: "love" in different:
          * Chinese: 爱 (U+7231)
            * 爱 = U+7231
          * Japanese: 愛 (U+611B)
            * 愛 = U+611B
          * Hindi: प्यार (U+092A U+094D U+092F U+093E U+0930)
            * प = U+092A
            * ् = U+094D
            * य = U+092F
            * ा = U+093E
            * र = U+0930
    * Images
      * Composed of pixels (picture elements)
      * Each pixel stores color values
      * RGB model: Red, Green, Blue — each channel is typically 0–255 (8 bits)
      * Example: A 1920×1080 image has over 2 million pixels, each storing RGB values
    * Audio / Music
      * Sound is a continuous wave — it must be sampled (measured at regular intervals)
      * Sample rate: how many times per second the sound wave is measured (e.g., 44,100 Hz = CD quality)
      * The higher the sample rate and bit depth, the better the audio quality
    * Video
      * A sequence of images (frames) played rapidly (e.g., 24, 30, or 60 frames per second)
      * Combined with audio synchronized to the frames
      * Uncompressed video requires enormous storage — compression is essential
  * Types of Programs / Applications
    * Console
    * Desktop / Window
    * Mobile
    * Web
    * Webservices and APIs
  * Source code vs Machine code
    * Source code is human readable code
    * Machine code is the actual instructions that the computer executes
      * Specific to the processor architecture (x86, ARM, etc.)
    * A source code is transformed into machine code through a process called compilation / interpretation
      * Compilation
        * Source code is converted to machine code before execution
      * Interpretation
        * Source code is converted to machine code during execution
      * Java introduced the idea of mixing compilation and interpretation
        * First compiles to bytecode
        * Then interprets the bytecode
        * Other technologies like .NET also use this approach
    * Examples: [_002_CodeExamples.md](./_002_CodeExamples.md)