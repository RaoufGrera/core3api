export function authHeader() {
    // return authorization header with jwt token
    let user = JSON.parse(localStorage.getItem("user"));
    console.log("Start authHeader");
    console.log(user);
    console.log(user.token);
    console.log("End authHeader");

    if (user && user.token) {
        return {
            "Authorization": "Bearer " + user.token
        };
    } else {
        return {};
    }
}