import { Component, OnInit } from '@angular/core';
import { Test } from "../../../core/models/test/test";
import { TestService } from "../../../core/services/test.service";
import { ConfirmationService } from "primeng/api";

@Component({
  selector: 'app-tests-page',
  templateUrl: './tests-page.component.html',
  styleUrls: ['./tests-page.component.sass']
})
export class TestsPageComponent implements OnInit {
    public tests: Test[] = [];

    constructor(
        private testService: TestService,
        private confirmationService: ConfirmationService
    ) { }

    ngOnInit(): void {
        this.getTests();
    }

    runTest(id: number) {
        let test = this.tests.find(t => t.id === id);
        this.confirmationService.confirm({
            header: `${test?.title}`,
            message: `${test?.description}`
        })
    }

    private getTests() {
        this.testService
            .getShuffledTests(2)
            .subscribe((tests) => {
                this.tests = tests;
            })
    }
}
