export class Contact {
  public firstname: string;
  public lastname: string;
  public emailaddress1: string;
  public mobilephone: string;
  public birthdate: string;

  constructor(firstname: string, lastname: string, emailaddress1: string, mobilephone: string, birthdate: string) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.emailaddress1 = emailaddress1;
    this.mobilephone = mobilephone;
    this.birthdate = birthdate;
  }
}
