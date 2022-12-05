import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AprazosComponent } from './aprazos.component';

describe('AprazosComponent', () => {
  let component: AprazosComponent;
  let fixture: ComponentFixture<AprazosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AprazosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AprazosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
