export class ButtonService {
  buttonOn = false;
  constructor() { }

  turnButtonOn(){
    this.buttonOn = true;
  }

  turnButtonOff(){
    this.buttonOn = false;
  }

}
