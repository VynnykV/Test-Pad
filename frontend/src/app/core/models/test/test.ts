import { Question } from "../question/question";

export interface Test {
    id: number;
    title: string;
    description: string;
    questions: Question[];
}
