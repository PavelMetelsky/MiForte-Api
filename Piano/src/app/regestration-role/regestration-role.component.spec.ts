import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { RegestrationRoleComponent } from './regestration-role.component';

describe('RegestrationRoleComponent', () => {
  let component: RegestrationRoleComponent;
  let fixture: ComponentFixture<RegestrationRoleComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ RegestrationRoleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegestrationRoleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
