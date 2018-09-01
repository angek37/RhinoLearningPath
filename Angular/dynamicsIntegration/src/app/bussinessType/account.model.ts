export class Account {
  public accountid: string;
  public name: string;
  public address1_stateorprovince: string;
  public address1_country: string;
  public address1_city: string;

  constructor(id: string, name: string, state: string, country: string, city: string) {
    this.accountid = id;
    this.name = name;
    this.address1_stateorprovince = state;
    this.address1_country = country;
    this.address1_city = city;
  }
}
