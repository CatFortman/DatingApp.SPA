import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'encodeUri'
})
export class EncodeUriPipe implements PipeTransform {

  transform(value: any, args?: any): any {
    return encodeURI(value);
  }
}
