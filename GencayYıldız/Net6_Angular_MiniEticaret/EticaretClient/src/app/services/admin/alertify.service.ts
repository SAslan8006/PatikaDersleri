import { Injectable } from '@angular/core';
declare var alertify:any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }
  // message(message:string,messageType:MessageType,position:Position,delay :number=3,dismissOthers:boolean=false){  

  message(message:string,options:Partial<AlertifyOptions>){  
    alertify.set('notifier','delay',options.delay); 
    alertify.set('notifier','position', options.position); 
    const msj=alertify[options.messageType](message);
    if (options.dismissOthers){
      msj.dismissOther(); 
    }
  }
  dismissAll(){
    alertify.dismissAll();
  }
}
export class AlertifyOptions{
  messageType:MessageType=MessageType.Message;
  position:Position=Position.BottomLeft;
  delay :number=3;
  dismissOthers:boolean=false;

}

export enum MessageType{
  Error="error",
  Message="message",
  Notify="notify",
  Warning="warning",
  Success="success"
}
export enum Position{
  TopCenter="top-center",
  TopRight="top-right",
  TopLeft="top-left",
  BottomCenter="bottom-center",
  BottomRight="bottom-right",
  BottomLeft="bottom-left"
}