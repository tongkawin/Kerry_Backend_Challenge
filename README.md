# Kerry Backend Challenge
1. POST/login Request{username: xxx, password: xxxx}
2. POST/register Request{username: xxx, password: xxxx, fullname: xxxx}
3. GET/books Get the list of books from https://api.itbook.store/1.0/search/mysql
4. POST/user/like Request{user_id: xxx, book_id: 1}

Use Swagger UI for test the REST API
## Install the project
```
git clone https://github.com/tongkawin/Kerry_Backend_Challenge.git
```
## Run the project
```
dotnet watch
```
# REST API
The REST API to the example app is described below.

## Register (POST/register)
```
curl -X 'POST' \
  'https://localhost:xxxx/api/Authenticate/register' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "username": "string",
  "fullname": "string",
  "password": "string"
}'
```
```
//Request
{
  "username": "string",
  "fullname": "string",
  "password": "string"
}
//Response(Success)
{
  "status": "Success",
  "message": "User created successfully"
}
```
## Login (POST/login)
```
curl -X 'POST' \
  'https://localhost:xxxx/api/Authenticate/login' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "username": "string",
  "password": "string"
}'
```
```
//Request
{
  "username": "string",
  "password": "string"
}
//Response(Success)
{
  "token": "string",
  "expiration": "DateTime"
}
```
## Get data (GET/books)
```
curl -X 'GET' \
  'https://localhost:xxxx/books' \
  -H 'accept: */*'
```
```
//Response
[
  {
    "title": "MySQL Stored Procedure Programming",
    "subtitle": "Building High-Performance Web Applications in MySQL",
    "isbn13": "9780596100896",
    "price": "$6.38",
    "image": "https://itbook.store/img/books/9780596100896.png",
    "url": "https://itbook.store/books/9780596100896"
  },
  {
    "title": "Learning MySQL and MariaDB",
    "subtitle": "Heading in the Right Direction with MySQL and MariaDB",
    "isbn13": "9781449362904",
    "price": "$38.70",
    "image": "https://itbook.store/img/books/9781449362904.png",
    "url": "https://itbook.store/books/9781449362904"
  },
  {
    "title": "MySQL Connector/Python Revealed",
    "subtitle": "SQL and NoSQL Data Storage Using MySQL for Python Programmers",
    "isbn13": "9781484236932",
    "price": "$24.27",
    "image": "https://itbook.store/img/books/9781484236932.png",
    "url": "https://itbook.store/books/9781484236932"
  },
  {
    "title": "MySQL Concurrency",
    "subtitle": "Locking and Transactions for MySQL Developers and DBAs",
    "isbn13": "9781484266519",
    "price": "$40.08",
    "image": "https://itbook.store/img/books/9781484266519.png",
    "url": "https://itbook.store/books/9781484266519"
  },
  {
    "title": "High Availability MySQL Cookbook",
    "subtitle": "Over 50 simple but incredibly effective recipes focusing on different methods of achieving high availability for MySQL databases",
    "isbn13": "9781847199942",
    "price": "$26.99",
    "image": "https://itbook.store/img/books/9781847199942.png",
    "url": "https://itbook.store/books/9781847199942"
  },
  {
    "title": "MySQL for Python",
    "subtitle": "Integrate the flexibility of Python and the power of MySQL to boost the productivity of your applications",
    "isbn13": "9781849510189",
    "price": "$29.99",
    "image": "https://itbook.store/img/books/9781849510189.png",
    "url": "https://itbook.store/books/9781849510189"
  },
  {
    "title": "MySQL 5.1 Plugin Development",
    "subtitle": "Extend MySQL to suit your needs with this unique guide into the world of MySQL plugins",
    "isbn13": "9781849510608",
    "price": "$26.99",
    "image": "https://itbook.store/img/books/9781849510608.png",
    "url": "https://itbook.store/books/9781849510608"
  },
  {
    "title": "MySQL Notes for Professionals",
    "subtitle": "",
    "isbn13": "1001620983366",
    "price": "$0.00",
    "image": "https://itbook.store/img/books/1001620983366.png",
    "url": "https://itbook.store/books/1001620983366"
  },
  {
    "title": "MySQL, 4th Edition",
    "subtitle": "",
    "isbn13": "9780132800754",
    "price": "$0.00",
    "image": "https://itbook.store/img/books/9780132800754.png",
    "url": "https://itbook.store/books/9780132800754"
  },
  {
    "title": "PHP and MySQL For Dummies, 3rd Edition",
    "subtitle": "",
    "isbn13": "9780470096000",
    "price": "$12.00",
    "image": "https://itbook.store/img/books/9780470096000.png",
    "url": "https://itbook.store/books/9780470096000"
  }
]
```
## Like book (POST/user/like)
```
curl -X 'POST' \
  'https://localhost:xxxx/user/like' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "user_id": "string",
  "book_id": "string"
}'
```
```
//Request
{
  "user_id": "string",
  "book_id": "1"
}
//Response(Success)
{
  "status": "Success",
  "message": "Book liked successfully"
}
```
