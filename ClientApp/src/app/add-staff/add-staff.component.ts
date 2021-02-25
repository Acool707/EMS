import { Component, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IDropdownSettings } from 'ng-multiselect-dropdown';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';



@Component({
  selector: 'app-add-staff',
  templateUrl: './add-staff.component.html',
  styleUrls: ['./add-staff.component.css']
})
export class AddStaffComponent implements OnInit {
  @Output() refreshTable = new EventEmitter();
  @ViewChild('registerUserForm') registerUserForm: NgForm;
  model: any = {};
  dropdownList = [];
  selectedItems = [];
  dropdownSettings: IDropdownSettings = {};

  userTypes: any[] = [
    {id: 1, name: 'Admin'},
    {id: 2, name:'Manager'},
    {id: 3, name: 'User'}
  ];

  departments: any[] = [
    { id : 1, name: 'Trade Department' },
    { id : 2, name: 'Sales Department' },
    { id : 3, name: 'Stock Control' },
    { id : 4, name: 'Production Control' },
    { id : 5, name: 'Admin' },
    { id : 6, name: 'temp' },
    { id : 7, name: 'Trade Department' },
    { id : 8, name: 'HR' },
    { id : 9, name: 'Sales Support' },
    { id : 10, name: 'EDD' },
    { id : 11, name: 'Graphics' },
    { id : 12, name: 'Quality Check' }
  ];

  locations: any[] = [
    { id: 1, name: 'Chatsworth House' },
    { id: 2, name: 'Sutton Park' },
    { id: 3, name: 'Broughton Castle' },
    { id: 4, name: "Belvoir Castle" },
    { id: 5, name: "Felbrigg Hall" },
    { id: 6, name: "Milton Manor" },
    { id: 7, name: "Temple Newsam" },
    { id: 8, name: "Nostell Priory" },
    { id: 9, name: "Belton House" },
    { id: 11, name: "Brasted Place" },
    { id: 12, name: "Blickling Hall" },
    { id: 13, name: "Hermitage" },
    { id: 14, name: "Assorted antique panels" },
    { id: 15, name: "Ghent" },
    { id: 16, name: "Abbotsford House" },
    { id: 17, name: "Prestwould Plantation" },
    { id: 18, name: "Drottingholm" },
    { id: 18, name: "Saltram House" },
    { id: 18, name: "Whistler Peacock Room" },
    { id: 19, name: "Palazzo Biscari" }
  ];
  
  companies: any[] = [
    {id: 1, name: 'de Gourney'},
    {id: 2, name: 'Gwambo Studios'},
    {id: 3, name: 'Cicil Wu Si'},
  ];

  Menus: any[] = [
    { item_id: 1, item_text: 'CRM'},
    { item_id: 2, item_text: 'Calendar'},
    { item_id: 3, item_text: 'Master Entry'},
    { item_id: 4, item_text: 'Manage Advance Fields'},
    { item_id: 5, item_text: 'Location'},
    { item_id: 6, item_text: 'Country Name & Code'},
    { item_id: 7, item_text: 'Discount'},
    { item_id: 8, item_text: 'Price Type'},
    { item_id: 9, item_text: 'Account Manager'},
    { item_id: 10, item_text: 'Category Master'},
    { item_id: 11, item_text: 'Address Book'},
    { item_id: 12, item_text: 'Add Company'},
    { item_id: 13, item_text: 'Search'},
    { item_id: 14, item_text: 'Relation Type Master'},
  ];
  
  Websites: any[] = [
    { item_id: 1, item_text: 'CRM'},
    { item_id: 2, item_text: 'DGS III'},
    { item_id: 3, item_text: 'PS'},
    { item_id: 4, item_text: 'TS'},
  ];

  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.dropdownList = [
      { item_id: 1, item_text: 'Mumbai' },
      { item_id: 2, item_text: 'Bangaluru' },
      { item_id: 3, item_text: 'Pune' },
      { item_id: 4, item_text: 'Navsari' },
      { item_id: 5, item_text: 'New Delhi' }
    ];
    this.selectedItems = [
      { item_id: 3, item_text: 'Pune' },
      { item_id: 4, item_text: 'Navsari' }
    ];
    this.dropdownSettings = {
      singleSelection: false,
      idField: 'item_id',
      textField: 'item_text',
      selectAllText: 'Select All',
      unSelectAllText: 'UnSelect All',
      itemsShowLimit: 3,
      allowSearchFilter: false
    };

    this.refreshTable.emit(false);
  }

  onItemSelect(item: any) {
    console.log(item);
  }
  onSelectAll(items: any) {
    console.log(items);
  }

  addUser() {
    //this.model.menus = JSON.stringify(this.model.menus);
    //this.model.websites = JSON.stringify(this.model.websites);
    this.accountService.register(this.model).subscribe(responce => {
      console.log(responce);
      this.toastr.success('New user Saved');
      this.registerUserForm.reset();
      this.refreshTable.emit(true);
      //this.cancel();
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
  }

}
