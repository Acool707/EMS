import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  model: any = {};


  constructor(public accountService: AccountService, private router: Router,
    private toastr: ToastrService) { }
  ngOnInit() {

  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/')
  }

}
