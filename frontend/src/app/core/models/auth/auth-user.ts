import { User } from "../user/user";
import { AccessToken } from "./access-token";

export interface AuthUser {
    user: User;
    token: AccessToken;
}
