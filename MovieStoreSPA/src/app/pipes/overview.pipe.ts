import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'overview'
})
export class OverviewPipe implements PipeTransform {

  transform(value: any): any {
    
    return value.substring(0,50)+"...";
  }

}
