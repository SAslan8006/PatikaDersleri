import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OrdersComponent } from './orders.component';
import { RouterModule } from '@angular/router';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { DialogModule } from 'src/app/dialogs/dialog.module';
import { ListComponent } from './list/list.component';
import { DeleteDirective } from 'src/app/directives/admin/delete.directive';
import { DeleteDirectiveModule } from 'src/app/directives/admin/delete.directive.module';



@NgModule({
  declarations: [
    OrdersComponent,
    ListComponent,
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path:"",component:OrdersComponent}      
    ]) ,
    MatSidenavModule, MatFormFieldModule, MatInputModule, MatButtonModule, MatTableModule, MatPaginatorModule,
    DialogModule,
    DeleteDirectiveModule
  ]
})
export class OrdersModule { }
