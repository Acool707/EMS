import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model: any = {};
  items: any[] = [
    { id: 1, name: 'Chatsworth House' },
    { id: 2, name: 'Sutton Park' },
    { id: 3, name: 'Broughton Castle' },
    { id: 4, name: "Belvoir Castle" },
    { id: 5, name: "Felbrigg Hall" },
    { id: 6, name: "Milton Manor" },
    { id: 7, name: "Temple Newsam" },
    { id: 8, name: "Nostell Priory" },
    { id: 9, name: "Belton House" },
    { id: 11, name:"Brasted Place"},
    { id: 12, name:"Blickling Hall"},
    { id: 13, name:"Hermitage"},
    { id: 14, name:"Assorted antique panels"},
    { id: 15, name:"Ghent"},
    { id: 16, name:"Abbotsford House"},
    { id: 17, name:"Prestwould Plantation"},
    { id: 18, name: "Drottingholm" },
    { id: 18, name: "Saltram House" },
    { id: 18, name: "Whistler Peacock Room" },
    { id: 19, name:"Palazzo Biscari"}
  ];

  constructor(public accountService: AccountService, private router: Router,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.router.navigateByUrl('/home');
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
  }

}
