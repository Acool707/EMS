import { Component, OnInit } from '@angular/core';
import { ColumnMode } from '@swimlane/ngx-datatable';

@Component({
  selector: 'app-staff-list',
  templateUrl: './staff-list.component.html',
  styleUrls: ['./staff-list.component.css']
})
export class StaffListComponent implements OnInit {
  ColumnMode = ColumnMode;

  rows = [
    {username:'ram', name:'Ram Chandra', email:'ram@gmail.com', department:'IT', usertype:'Admin', location:'Kolkata', access:'All',}
    //{ name: 'Austin', gender: 'Male', company: 'Swimlane', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Dany', gender: 'Male', company: 'KFC', },
    //{ name: 'Molly', gender: 'Female', company: 'Burger King', }
  ];
  columns = [];
  constructor() { }

  ngOnInit(): void {
    this.columns = [
      { prop: 'username', name: 'Username' },
      { prop: 'name', name: 'Name' },
      { prop: 'email', name: 'Email' },
      { prop: 'department', name: 'Department' },
      { prop: 'usertype', name: 'User Type' },
      { prop: 'location', name: 'Location' },
      { prop: 'access', name: 'Access' },
      { prop: 'actions', name: 'Actions' }
    ];

  }

}
