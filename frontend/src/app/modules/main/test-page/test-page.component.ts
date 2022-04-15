import { Component, OnInit, ViewChild } from '@angular/core';
import { Test } from "../../../core/models/test/test";
import { TestService } from "../../../core/services/test.service";
import { ActivatedRoute, Router } from "@angular/router";
import { Subject, takeUntil } from "rxjs";
import { Answer } from "../../../core/models/answer/answer";
import { DataView } from "primeng/dataview";

@Component({
  selector: 'app-test-page',
  templateUrl: './test-page.component.html',
  styleUrls: ['./test-page.component.sass']
})
export class TestPageComponent implements OnInit {
    @ViewChild('dataView') dataView: DataView;
    public test = {} as Test;
    public id: number;

    isFinished: boolean;
    currentAnswer: Answer;

    private unsubscribe$ = new Subject<void>();

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private testService: TestService
    ) { }

    ngOnInit(): void {
        this.route.params.pipe(
            takeUntil(this.unsubscribe$)
        ).subscribe(() => {
            this.id = this.route.snapshot.params['id'];
            this.getTest();
        });
    }

    getTest() {
        this.testService
            .getById(this.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (test) => {
                    this.test = test
                }
            );
    }

    handleClick(answer: Answer) {
        if(this.currentAnswer) {
            this.currentAnswer.isPicked = false;
            this.setCurrentAnswer(answer);
        }
        else {
            this.setCurrentAnswer(answer);
        }
    }

    nextPage() {
        this.dataView.paginate({first: this.dataView.first + 1, rows: 1})
    }

    isLastPage() {
        return this.test.questions.length === this.dataView.first + 1;
    }

    private setCurrentAnswer(answer: Answer) {
        this.currentAnswer = answer;
        this.currentAnswer.isPicked = true;
    }

    handleOtherPageOpen() {
        this.currentAnswer = undefined!;
    }

    showTestResult() {
        this.isFinished = true;
    }
}
