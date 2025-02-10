# Library Management API
# Explanation of Each CRUD Operation
1️⃣ Get All Books (GET /api/books)

    Retrieves a list of all books stored in the database.
    Uses async-await to perform asynchronous database queries.

2️⃣ Get a Specific Book by ID (GET /api/books/{id})

    Finds a book using the given id and returns it.
    If the book does not exist, returns a 404 Not Found response.

3️⃣ Create a New Book (POST /api/books)

    Accepts a Book object in the request body.
    Saves the new book to the database.
    Returns 201 Created with the newly created book details.

4️⃣ Update an Existing Book (PUT /api/books/{id})

    Finds the book by id and updates its properties.
    Saves changes in the database.
    Returns 204 No Content if the update is successful.

5️⃣ Delete a Book (DELETE /api/books/{id})

    Finds a book by id and removes it from the database.
    Returns 204 No Content if the deletion is successful.
