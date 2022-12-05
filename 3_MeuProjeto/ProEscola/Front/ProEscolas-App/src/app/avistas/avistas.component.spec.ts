import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AvistasComponent } from './avistas.component';

describe('AvistasComponent', () => {
  let component: AvistasComponent;
  let fixture: ComponentFixture<AvistasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AvistasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AvistasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
