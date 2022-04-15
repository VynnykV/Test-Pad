import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Login } from "../../../core/models/auth/login";
import { AuthService } from "../../../core/services/auth.service";
import { Router } from "@angular/router";
import { MessageService } from "primeng/api";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {
    form!: FormGroup;

    constructor(
        private authService: AuthService,
        private router: Router,
        private messageService: MessageService
    ) { }

    ngOnInit(): void {
        this.form = new FormGroup({
            email: new FormControl('', Validators.required),
            password: new FormControl('', Validators.required)
        });
    }

    submit() {
        const login = this.form.value as Login;
        this.authService.login(login)
            .subscribe(() => {
                this.router.navigate(['/main/tests']).then(() => {
                    this.messageService.add({severity:'success', summary:'Welcome back!', detail:'You have successfully logged in'});
                });
            },
            error => {
                this.messageService.add({severity:'error', summary:'Error', detail: `${error.error}`});
            })
    }
}
