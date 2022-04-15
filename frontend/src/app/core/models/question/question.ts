import { Answer } from "../answer/answer";

export interface Question {
    id: number;
    content: string;
    answers: Answer[];
}
