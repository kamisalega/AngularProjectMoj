import { InjectionToken } from '@angular/core';

export let TOASTR_TOKEN = new InjectionToken<any>('toastr')

export interface TOASTR_TOKEN {
    
    success (msg: string, title?: string): void;
    info (msg: string, title?: string): void;
    warining (msg: string, title?: string): void;
    error (msg: string, title?: string): void;
    
}