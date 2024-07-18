---
name: Create new endpoint
about: Use this template for request the creation of new endpoint
title: As a Team, we need to create endpoint_name in module_name
labels: backend, enhancement
assignees: leonardoalvarez20

---

As a Developer I need to create the following endpoint to **"explain the action and module"**:

POST: `api/v1/customer/sign-up`

With the request body and all the fields as required:

```
{
    "name": "Jesus Leobardo",
    "lastname": "Chiapas Sierra",
    "phone": "668-8205850",
    "email": "leo.chiapas@gmail.com",
    "password": "leochiapas123+"
}
```

As a Developer I need to create the following schema to store customer:
```
customer

id: uuid
name: str
lastname: str
phone: str
email: str
password: str
```
- All the properties in the schema are required.
- `phone` and `email` must be unique, no duplication of the value is allowed.

Acceptance Criteria:

- [ ] If all the information is given the new customer must exist in mongodb
- [ ] If a property is missing we must return `400 Bad Request` with the missing properties in the response message.
- [ ] If a unique property is already in use, we must return `400 Bad Request` with the response message "Email or Phone number already in use".

Parent issue:

- Type de parent issue.
