# Product Manager
It is a console application for depository and products management. Developed by Vieronika Koliesnikova (SE-2) as [koliesnikvv](https://github.com/koliesnikvv) and Anastasia Trekurova (CS-2) as [stacytrek](https://github.com/stacytrek).

This application allows users to view all depositories and their content, browse products by category, check product prices (per item or total sum for all items of a specific product, calculate total value of products in a depository

## Entities:
* Depository is a first-level entity

* Product is a second-level entity

## The solution consists of 3 libraries and a project for a console program as required:

### 1. StorageClasses (Class Library for data storage)

Contains classes that are responsible only for data storage 

* ProductsStorage.cs - class for storing products data

* DepositoryStorage.cs - class for storing depositaries data

* ProductsCategory.cs - enum for products categories

* DepositoryLocation.cs - enum for depositories locations

### 2. Services (Class Library for services)

Contains services for data access (actually it kind of reminds of data bae, where we got all of our products and depositories saved)

* StarterStorage.cs - storage with initial data

* ProcessingStorage.cs - service for accessing storage data

### 2. CalculationClasses (Class Library for calculations)

Contains classes that add calculated fields

* ProductsCalculations.cs - wrapper for product with calculated totalPrice field

* DepositoryCalculations.cs - wrapper for depository with calculated totalValue field

### ProductManager (as a console application), was developed for user interface:
Program.cs - contains menu and user interaction

#### To run:
1. Clone the repository
2. Open 'ProductManager.sln' in Visual Studio
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)
