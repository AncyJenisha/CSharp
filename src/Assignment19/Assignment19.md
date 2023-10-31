# Advanced Linq Operations

This C# program demonstrates various advanced LINQ (Language-Integrated Query) operations. 
LINQ is a powerful feature in C# that allows you to work with collections of data in a query-like syntax. 
This program includes the following features:

## Program.cs
- The entry point of the program.
- It presents a menu of advanced LINQ operations for the user to choose from.
- Based on the user's choice, it invokes different LINQ operations on product data.

## Product.cs
- Defines the `Product` class with properties like ProductId, ProductPrice, ProductName, and ProductCategory.

## ProductsManager.cs
- Manages a list of products and provides methods to initialize it with default products.
- Creates and adds sample product instances to the product list.

## Supplier.cs and SupplierManager.cs
- Define the `Supplier` class with properties like SupplierId, SupplierName, and ProductId.
- `SupplierManager` manages a list of suppliers and provides methods to initialize it with default suppliers.
- Creates and adds sample supplier instances to the supplier list.

## BasicLinqQueries.cs
- Demonstrates basic and complex LINQ queries on the list of products.
- Includes methods for filtering products and grouping products by category.

## LinqToObjects.cs
- Demonstrates LINQ operations on an array of integers.
- Finds unique pairs of integers that add up to a given target sum.

## PerformanceConsiderationsOfLinq.cs
- Demonstrates performance considerations when working with LINQ.
- Filters and sorts books from the list of products.

## AdvancedLinqFeatures.cs
- Demonstrates advanced LINQ features.
- Filters the product list based on user-defined criteria.
- Implements filtering using expression trees.
- Creates dynamic LINQ queries.

## QueryBuilder.cs
- Defines a `QueryBuilder` class for building LINQ queries dynamically.
- Allows filtering, sorting, joining, and executing queries on a list of products.

## BuildQueryImplementor.cs
- Implements a `QueryBuilder` to demonstrate the use of a dynamic LINQ query.
- Filters, sorts, and joins products and suppliers using the `QueryBuilder`.

## ChoiceOfOperation.cs
- Defines an enum `ChoiceOfOperation` to represent user menu choices.

## InputValidators.cs
- Provides methods for validating and parsing user input for integers, floats, and strings.
