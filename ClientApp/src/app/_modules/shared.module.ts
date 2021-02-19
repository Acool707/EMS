import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ToastrModule } from 'ngx-toastr';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }),
    BsDropdownModule.forRoot(),
    NgxDatatableModule,
  ],

  exports: [
    ToastrModule,
    BsDropdownModule,
    NgxDatatableModule,
    
  ],
})
export class SharedModule { }
