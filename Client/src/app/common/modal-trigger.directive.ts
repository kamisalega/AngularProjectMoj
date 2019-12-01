import {Directive, Inject, OnInit, ElementRef, Input} from '@angular/core';
import {JQ_TOKEN} from "./index";

@Directive({
    selector: '[modal-trigger]'
})
export class ModalTriggerDirective implements OnInit {

    private htmlElementDom: HTMLElement;
    @Input('modal-trigger') modalId: string;

    constructor(elementRef: ElementRef, @Inject(JQ_TOKEN) private $: any) {

        this.htmlElementDom = elementRef.nativeElement;
    }

    ngOnInit(): void {
        this.htmlElementDom.addEventListener('click', ev => {
            this.$(`#${this.modalId}`).modal({})
        })

    }

}
