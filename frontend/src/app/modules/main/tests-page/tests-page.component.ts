import { Component, OnInit } from '@angular/core';
import { Test } from "../../../core/models/test/test";
import { TestService } from "../../../core/services/test.service";
import { ConfirmationService, MessageService } from "primeng/api";
import { Router } from "@angular/router";

@Component({
  selector: 'app-tests-page',
  templateUrl: './tests-page.component.html',
  styleUrls: ['./tests-page.component.sass']
})
export class TestsPageComponent implements OnInit {
    public tests: Test[] = [];

    constructor(
        private testService: TestService,
        private confirmationService: ConfirmationService,
        private router: Router,
        private messageService: MessageService
    ) { }

    ngOnInit(): void {
        this.getTests();
    }

    runTest(id: number) {
        let test = this.tests.find(t => t.id === id);
        this.confirmationService.confirm({
            header: `${test?.title}`,
            message: `${test?.description}`,
            accept: () => {
                this.router.navigate(['/main/test', id]).then(() => {
                    this.messageService.add({severity:'success', summary:'Test is started', detail:'Good Luck!'});
                });
            }
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
