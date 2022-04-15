import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { AuthService } from "../../../core/services/auth.service";
import { Register } from "../../../core/models/auth/register";
import { Router } from "@angular/router";
import { MessageService } from "primeng/api";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.sass']
})
export class RegisterComponent implements OnInit {
    form!: FormGroup;

    constructor(
        private authService: AuthService,
        private router: Router,
        private messageService: MessageService
    ) { }

    ngOnInit(): void {
      this.form = new FormGroup({
          username: new FormControl('', Validators.required),
          email: new FormControl('', Validators.required),
          password: new FormControl('', Validators.required)
      });
    }

    submit() {
        const register = this.form.value as Register;
        this.authService.register(register)
        .subscribe(() => {
            this.router.navigate(['/login']).then(() => {
                this.messageService.add({severity:'success', summary:'Congratulate!', detail:'You have successfully register'});
            });
        },
        error => {
            this.messageService.add({severity:'error', summary:'Error', detail:`${error.error}`});
        })
    }
}
