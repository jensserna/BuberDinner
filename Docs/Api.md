# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
    - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
    - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Jens",
    "lastName": "Serna",
    "email": "jens_serna@hotmail.com",
    "password": "test1234"
}
```

### Register Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstName": "Jens",
    "lastName": "Serna",
    "email": "jens_serna@hotmail.com",
    "token": "eyJhb...z9dslwklsYl"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "jens_serna@hotmail.com",
    "password": "test1234"
}
```

### Login Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstName": "Jens",
    "lastName": "Serna",
    "email": "jens_serna@hotmail.com",
    "token": "eyJhb...z9dslwklsYl"
}
```
