import {Directive, Inject, OnInit, ElementRef} from '@angular/core';
import {JQ_TOKEN} from "./j-query.service";

@Directive({
    selector: '[modal-trigger]'
})
export class ModalTriggerDirective implements OnInit {

    private htmlElementDom: HTMLElement;

    constructor(elementRef: ElementRef, @Inject(JQ_TOKEN) private $: any) {
      
        this.htmlElementDom = elementRef.nativeElement;
    }

    ngOnInit(): void {
      this.htmlElementDom.addEventListener('click', ev => 
      {
        this.$('#simple-modal').modal({})
      })
       
    }

}
