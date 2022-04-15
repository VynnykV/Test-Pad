import { Component, Input, OnInit } from '@angular/core';
import { Test } from "../../../../core/models/test/test";

@Component({
  selector: 'app-test-result',
  templateUrl: './test-result.component.html',
  styleUrls: ['./test-result.component.sass']
})
export class TestResultComponent implements OnInit {
    @Input() test: Test;
    constructor() { }

    ngOnInit(): void {
    }

    getRightAnswersPercentage() {
        let rightAnswers = 0;
        this.test.questions?.forEach(q => {
            q.answers?.forEach(a => {
                if(a.isPicked === a.isCorrect) {
                    rightAnswers += 1;
                }
            });
        });
        return (rightAnswers/this.test.questions?.length) * 100;
    }
}
