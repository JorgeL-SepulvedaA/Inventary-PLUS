# Inventary-PLUS

Nowadays, there's a lot of programs helping companies in inventary tasks, such as having a good inventary-processing management. And so, due to the urge to be aware with all these technologies, we've created a inventary system that will solve all your inventary-stuff in just one place... Here we introduce you to the greatest app, called: ɪɴᴠᴇɴᴛᴀʀʏ-ᴘʟᴜꜱ.

# How to use

The app is MVC-based, which means that the app allows you to surf between a couples of modules to make your stancy more confortable doing all your work in the same places interacting with all the funcionalities. To understand how this work, here is a intruction for you to follow step by step to start working. (Still in process)

    1. Adjust your configuration management.

# Database mapping

    The structure of the database:
        The login - is linked to the Users table.
        The users table contains the fields:
            Your id - Identification
            Name
            Lastname
            Mail - To access the platform.
            Password
            Creation date - When your user was created.
            Security Question - In case you lose or forget your password.
            Security Response

    The crud - is linked to the Warehouse, Items, Transactions, Inventory tables.
        The Warehouse table contains the fields:
            Id - Identify the Product in Warehouse.
            Description - short story of the ID.
            Status - whether it is available or not.

        The items table contains the fields:
            Id - Identification.
            Description - short story of the ID.
            Stock - Quantity available.
            IdInventory - Relationship with the inventory table.
            CostoUnit - Unit cost of the item.
            Status - whether it is available or not.

        The Transactions table contains the fields:
            Id - Identification.
            IdTipoTransaccion - You can only enter a number from 1 to 4, referring to the static table that has the types of transactions.
            IdArticulo - Connection with the articles table.
            Date - When the transaction was made.
            Quantity - Qty Items.
            Amount - Total of the items.

        A view - Connection of the warehouse and items tables -It is called Stock x Warehouse-:
            You will be able to see the IdAlmacen, IdIdArticulo and Existence of the article.

        Static tables:
            - Transaction type - table name
                Its fields are:

                IdTypeTransaction | TransactionType:
                ------------------|-----------------
                    1 -             | Input
                ------------------|-----------------
                    2 -             | Output
                ------------------|-----------------
                    3 -             | Transfer
                ------------------|-----------------
                    4 -             | Adjust

            - SecurityQuestions - table name
                Its fields are:

                IdQuestionSecurity | DescriptionQuestion
                -------------------|-------------------------------
                    1-             | What is your first pet's name?
                -------------------|-------------------------------
                    2-             | Where you were born?
                -------------------|-------------------------------
                    3-             | What is your mother's name?
                -------------------|-------------------------------
                    4-             | What your favorite color?

# Group 7

we are in charge of the inventary-app's development, every each one of us taking care of a particular task in the project. We are:

    1. Jaime David Terrero Félix  - 202010619
    2. Arianny Rachell Rodríguez Ogando - 202020374
    3. Jorge Luis Sepúlveda Abreu - 202010714
