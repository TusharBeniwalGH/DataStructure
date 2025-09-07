# Data Structures & Algorithms

A comprehensive repository containing C# implementations of various data structures and algorithms with detailed explanations and examples.

## 📚 Contents

### Arrays
Collection of array-based algorithms and techniques implemented in C#:

#### Sliding Window Technique
The sliding window technique is an efficient method used to calculate the maximum sum of k consecutive elements from an array.

**Implementation Details:**
- **Input:** Array `[1,4,2,10,23,3,1,0,20]` with window size `k=4`
- **Output:** Maximum sum of any 4 consecutive elements with detailed console output
- **Method:** Calculate initial window sum, then slide by adding next element and removing first element

**How it works:**
1. Validate input (check if k is not greater than array length)
2. Calculate the sum of the first window of size k
3. Move the window by one position (add the next element and subtract the first element of the previous window)
4. At each step, check if the current sum is greater than the maximum sum found so far
5. Update the maximum sum if a larger sum is found
6. Display results with formatted output showing the array and maximum sum

**Time Complexity:** O(n) where n is the number of elements in the array  
**Space Complexity:** O(1)

**Features:**
- Input validation for edge cases
- Formatted console output with array display
- User-friendly result presentation
- Efficient single-pass algorithm

#### Array Rotation
Implementation of right array rotation using temporary array approach.

**Current Implementation:**
- **Input:** Array `[1,2,5,7,9]` with rotation count `k=2`
- **Method:** Right rotation using auxiliary array
- **Approach:** Uses temporary array to store elements during rotation

**Algorithm Steps:**
1. Create a temporary array of the same size as original
2. Copy elements from position `(n-k)` onwards to the beginning of temp array
3. Copy remaining elements from start to position `(n-k-1)` into temp array
4. Display the rotated array elements

**Time Complexity:** O(n)  
**Space Complexity:** O(n) - uses auxiliary array

**Example Output:** `[1,2,5,7,9]` rotated right by 2 positions produces the rotated sequence

**Implementation Features:**
- Clean, streamlined code without commented alternatives
- Direct array manipulation with auxiliary storage
- Console output for verification

#### Duplicate Number Detection
Implementation of an algorithm to find all duplicate numbers in an array using Dictionary-based counting.

**Current Implementation:**
- **Input:** Array `[4, 8, 9, 1, 2, 5, 4]`
- **Method:** Dictionary-based frequency counting with LINQ filtering
- **Output:** All numbers that appear more than once in the array

**Algorithm Steps:**
1. Create a Dictionary to store number frequencies
2. Iterate through the array and count occurrences of each number
3. Use LINQ to filter numbers with count > 1
4. Display the duplicate numbers as a comma-separated list

**Time Complexity:** O(n) where n is the number of elements in the array  
**Space Complexity:** O(k) where k is the number of unique elements

**Example Output:** For the given array `[4, 8, 9, 1, 2, 5, 4]`, outputs: `4`

**Implementation Features:**
- Dictionary-based efficient counting
- LINQ operations for filtering and selection
- Proper namespace organization
- Clean console output formatting

#### N-Bonacci Numbers
Implementation of N-bonacci sequence generator that prints the first m numbers of an n-bonacci sequence.

**Current Implementation:**
- **Parameters:** `n=5` (sequence type), `m=10` (count of numbers to generate)
- **Method:** Iterative approach using array-based sliding window
- **Sequence Type:** 5-bonacci (each number is sum of previous 5 numbers)

**Algorithm Steps:**
1. Initialize array with first `(n-1)` elements as 0
2. Set the nth element as 1 (base case)
3. For each subsequent position, sum the previous n elements using sliding window
4. Use nested loops with moving indices (k and l) to calculate sums efficiently
5. Display the complete sequence

**Time Complexity:** O(m × n) where m is count of numbers and n is the sequence type  
**Space Complexity:** O(m) for storing the sequence

**Example Output:** For 5-bonacci sequence with 10 numbers:
`0 0 0 0 1 1 2 4 8 16`

**Sequence Pattern:**
- First 4 numbers: 0
- 5th number: 1 (base case)
- Each subsequent number: sum of previous 5 numbers

**Additional Features:**
- Dictionary-based demonstration with LINQ operations
- Conditional logic for handling edge cases
- Console output for sequence visualization
- Efficient sliding window implementation with boundary checks

## 🚀 Getting Started

Each algorithm is implemented with:
- Clear code comments
- Example usage
- Time and space complexity analysis

## 📁 Project Structure

```
Arrays/
├── Arrays.sln                    # Main solution file (includes all projects)
├── Sliding-Window/
│   ├── Program.cs               # Sliding window max sum implementation
│   └── Sliding-Window.csproj    # C# project file
├── Array-Rotate/
│   ├── Program.cs               # Right array rotation implementation
│   └── Array-Rotate.csproj     # C# project file
├── Duplicate/
│   ├── Program.cs               # Duplicate number detection algorithm
│   └── Duplicate.csproj         # C# project file
└── N-BonaciNumber/
    ├── Program.cs               # N-bonacci sequence generator
    └── N-BonaciNumber.csproj    # C# project file
```

**Note:** Build artifacts (bin/ and obj/ folders) are excluded from version control and will be generated automatically when building the projects.

## 🛠️ Technology Stack

- **Language:** C#
- **IDE:** Visual Studio 2022 (Version 17.5.2.0)
- **Framework:** .NET
- **Project Type:** Console Applications

## 🚀 Running the Code

Each project can be run using the following methods:

1. **Using Main Solution (Recommended):**
   - Open `Arrays/Arrays.sln` in Visual Studio
   - All four projects are included in the solution
   - Set desired project as startup project
   - Build and run the solution

2. **Using Command Line:**
   ```bash
   cd Arrays/[project-name]
   dotnet run
   ```

3. **Using Visual Studio (Individual Projects):**
   - Navigate to the specific project folder
   - Open the `.csproj` file directly in Visual Studio
   - Build and run the project

## 🤝 Contributing

Feel free to contribute by adding new algorithms, improving existing implementations, or enhancing documentation.
