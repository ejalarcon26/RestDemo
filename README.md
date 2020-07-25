# RestDemo

1. Open Visual Studio 2019.
2. Click Open a project or solution.
3. Select "RestDemo.sln".
4. Hit "F5" or Click the Run button.
5. When the webpage is loaded, click "API".
6. Open Postman.
7. Check if SSL certificate verification in ON(When it is, turn it OFF in File>Settings).
8. The endpoint will be "https://localhost:44388/api/values"
Note: the port number may be different from your machine check the url in the loaded webpage.
9. Try the GET, POST, PUT, DELETE.

[GET]
-https://localhost:44388/api/values

[POST]
-https://localhost:44388/api/values
-Click body and select Raw also select JSON
Example: 
{
    "user_Id":112233,
    "user_fname":"EJ",
    "user_lname":"ALARCON",
    "birthday":"08-26-1997",
    "user_gender":"MALE",
    "is_vip":true,
    "user_balance":200.95
}

[PUT]
-https://localhost:44388/api/values
-Click body and select Raw also select JSON
Example: 
{
    "user_Id":112233,
    "user_fname":"Test",
    "user_lname":"Update",
    "birthday":"08-26-1997",
    "user_gender":"MALE",
    "is_vip":true,
    "user_balance":100.95
}

[DELETE]
-https://localhost:44388/api/values/112233
