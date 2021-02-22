import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ToastrModule } from 'ngx-toastr';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ModalModule } from 'ngx-bootstrap/modal';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }),
    BsDropdownModule.forRoot(),
    NgxDatatableModule,
    ModalModule.forRoot(),
    BsDatepickerModule.forRoot()
  ],

  exports: [
    ToastrModule,
    BsDropdownModule,
    NgxDatatableModule,
    ModalModule,
    BsDatepickerModule
  ],
})
export class SharedModule { }
