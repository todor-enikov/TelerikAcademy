# Database Systems - Overview
## Questions

   1. What database models do you know?
     * Relational model
     * NoSQL

   2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
     * Data Dictionary Management 
     * Data Storage Management 
     * Data Transformation and Presentation
     * Security Management 
     * Multiuser Access Control
     * Backup and Recovery Management 
     * Transaction Management 

   3. Define what is "table" in database terms.
     A table is a collection of related data held in a structured format within a database. It consists of columns, and rows.

   4. Explain the difference between a primary and a foreign key.
     * Primary Key
      - Primary key uniquely identify a record in the table. 
      - Primary Key can't accept null values. 
      - By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index.
      - We can have only one Primary key in a table.
     * Foreign Key  
      - Foreign key is a field in the table that is primary key in another table.   
      - Foreign key can accept multiple null value. 
      - Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
      - We can have more than one foreign key in a table. 

   5. Explain the different kinds of relationships between tables in relational databases.
      The differe types of relationships are:
       * One-to-Many Relationship
       * Many-to-Many Relationships
       * One-to-One Relationships  

   6. When is a certain database schema normalized?
      It is normalized when we organize the columns (attributes) and tables (relations) of a relational database to reduce data redundancy and improve data integrity.

   7. What are the advantages of normalized databases?
       * Smaller database: By eliminating duplicate data, you will be able to reduce the overall size of the database.
       * Better performance:
        - Narrow tables: Having more fine-tuned tables allows your tables to have less columns and allows you to fit more records per data page.
        - Fewer indexes per table mean faster maintenance tasks such as index rebuilds.
        - Only join tables that you need.

   8. What are database integrity constraints and when are they used?
      Before one can start to implement the database tables, one must define the integrity constraints. Intergrity means something like 'be right' and consistent. The data in a database must be right and in good condition.
       * data types
       * primary / foreign keys
       * unique
       * allow null values

   9. Point out the pros and cons of using indexes in a database.
      Indexes provide fast search at the cost of slow inserts.
   10. What's the main purpose of the SQL language?
      Purpose of SQL Structured Query Language is to provide a Structured way by which one can Query information in database using a standard Language.
   11. What are transactions used for?
     A transaction symbolizes a unit of work performed within a database management system (or similar system) against a database, and treated in a coherent and reliable way independent of other transactions. A transaction generally represents any change in database. Transactions in a database environment have two main purposes:
       * To provide reliable units of work that allow correct recovery from failures and keep a database consistent even in cases of system failure, when execution stops (completely or partially) and many operations upon a database remain uncompleted, with unclear status.
       * To provide isolation between programs accessing a database concurrently. If this isolation is not provided, the programs' outcomes are possibly erroneous.

   12. What is a NoSQL database?
       A NoSQL database provides a mechanism for storage and retrieval of data which is modeled in means other than the tabular relations used in relational databases. 

   13. Explain the classical non-relational data models.
       * key-value - hashtable, super fast, often used in memory bds
       * document - xml/ json/ bson - MongoDB (bson)- stores "documents"
       * wide-column - large scale, versioned data
       * graph - realtionships between data
       
   14. Give few examples of NoSQL databases and their pros and cons.
       * MondoDB
       * Redis
       * MarkLogic
       * Datastax      
